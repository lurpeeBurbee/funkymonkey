using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject GameArea;
    GameObject token;
    List<int> faceIndexes = new List<int> { 0, 1, 2, 3, 4, 0, 1, 2, 3, 4 };
    int maxCards;
    public static System.Random rnd = new System.Random();
    public int shuffleNum = 0;
    int[] visibleFaces = { -1, -2 };
    bool success;

    void Start()
    {
        //int originalLength = faceIndexes.Count;
        float yPosition = token.transform.position.y;
        float xPosition = token.transform.position.x + 140;
        maxCards = 7;
        for (int i = 0; i < maxCards; i++)
        {
            //shuffleNum = rnd.Next(0, (faceIndexes.Count));
            shuffleNum = rnd.Next(0, (maxCards + 1));
            var temp = Instantiate(token, new Vector3(
                xPosition, yPosition, 0),
                Quaternion.identity, GameArea.transform);

            temp.GetComponent<MainToken>().faceIndex = faceIndexes[shuffleNum];
            faceIndexes.Remove(faceIndexes[shuffleNum]);

            //xPosition += 140;
            //if (i == ((originalLength / 2) - 2))
            //{
            //    xPosition = 140f;
            //    yPosition = 180f;
            //}
        }
        token.GetComponent<MainToken>().faceIndex = faceIndexes[0];
    }

    public bool TwoCardsUp()
    {
        bool cardsUp = false;
        if(visibleFaces[0] >= 0 && visibleFaces[1] >= 0)
        {
            cardsUp = true;
            print("2 cards are up!");
        }
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
            Debug.Log("Found 2 pairs!");
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
