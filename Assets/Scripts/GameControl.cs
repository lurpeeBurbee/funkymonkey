using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject GameArea;
    GameObject token;
    List<int> faceIndexes = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
    public int maxCards;
    public static System.Random rnd = new System.Random();
    public int shuffleNum = 0;
    int[] visibleFaces = { -1, -2 };
    bool success;
    public GameObject[] objects;
    int cardsLeft;
    public GameObject monkeyHead;

    void Start()
    {
        maxCards = CardAmountData.cardAmount-1;
        cardsLeft = 1;

        //int originalLength = faceIndexes.Count;
        GameObject.FindGameObjectWithTag("StartMusic").GetComponent<StartMusic>().StopStartMusic();

        float yPosition = token.transform.position.y;
        float xPosition = token.transform.position.x + 140;
        //maxCards = 7;

        List<int> facesThisRound = new List<int>();
        int uniqueCards = (maxCards+1) / 2;

        for (int i = 0; i < uniqueCards; i++)
        {
            shuffleNum = rnd.Next(0, (faceIndexes.Count));
            int num = faceIndexes[shuffleNum];

            facesThisRound.Add(num);
            facesThisRound.Add(num);

            faceIndexes.Remove(num);
            faceIndexes.Remove(num);
        }

        // Randomly remove one instrument to avoid getting odd cards
        /*int faceToRemove = rnd.Next(0, 4);
        faceIndexes.Remove(faceToRemove);
        faceIndexes.Remove(faceToRemove);*/
        //Debug.Log("Removed " + faceToRemove);

        for (int i = 0; i < maxCards; i++)
        {
            shuffleNum = rnd.Next(0, (facesThisRound.Count));

            var temp = Instantiate(token, new Vector3(
                xPosition, yPosition, 0),
                Quaternion.identity, GameArea.transform);

            temp.GetComponent<MainToken>().faceIndex = facesThisRound[shuffleNum];
            facesThisRound.Remove(facesThisRound[shuffleNum]);
            cardsLeft++;
        }
        token.GetComponent<MainToken>().faceIndex = facesThisRound[0];
    }

    public bool TwoCardsUp()
    {
        bool cardsUp = false;
        if (visibleFaces[0] >= 0 && visibleFaces[1] >= 0)
        {
            cardsUp = true;
            print("2 cards are up!");
        }

        //objects = Game.FindGameObjectsWithTag("Card");
        //foreach (var obj in objects)
        //{
        //    obj.GetComponent<Button>();

        //    if (obj.GetComponent<Button>().image.sprite != back)
        //    {
        //        obj.GetComponent<Button>().interactable = false;
        //    }

        //}

        return cardsUp;
    }

    public void AddVisibleFace(int index)
    {
        if(visibleFaces[0] == -1)
        {
            visibleFaces[0] = index;
        }
        else if (visibleFaces[1] == -2)
        {
            visibleFaces[1] = index;
        }
    }

    public void RemoveVisibleFace(int index)
    {
        if (visibleFaces[0] == index)
        {
            visibleFaces[0] = -1;
        }
        else if (visibleFaces[1] == index)
        {
            visibleFaces[1] = -2;
        }
    }

    public bool CheckMatch()
    {
        success = false;
        if(visibleFaces[0] == visibleFaces[1])
        {
            visibleFaces[0] = -1;
            visibleFaces[1] = -2;
            success = true;
            cardsLeft-=2;

            // Game over
            if ( cardsLeft == 0)
            {
                monkeyHead.GetComponent<MonkeyScript>().MonkeySound();
                MedalManager.hasPlayed = true;
                SceneChanger.clearMedals = false;

            }
            Debug.Log("Cards left: " + cardsLeft);
        }
        print("success is " + success);
        return success;
    }

    private void Awake()
    {
        token = GameObject.Find("Button");
        GameArea = GameObject.Find("Main Canvas");

    }

}
