using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class GameplayRelaxed : MonoBehaviour
{
    public GameObject GameControl;
    public GameObject cardPrefab;
    List<int> faceindexes = new List<int> { 0, 1, 2, 3, 0, 1, 2, 3 };
    public static System.Random rnd = new System.Random();
    public int shuffleNumber = 0;
    int[] visibleFaces = { -1, -2 };

    public TextMeshProUGUI text;

    void Start()
    {

        int originalLength = faceindexes.Count;
        float yPosition = 400f;
        float xPosition = 140f;

        for (int i = 0; i < 8; i++)
        {
            shuffleNumber = rnd.Next(0, (faceindexes.Count));

            var temp = Instantiate<GameObject>(cardPrefab, new Vector3(xPosition, yPosition, 0), Quaternion.identity, GameControl.transform);

            temp.GetComponentInChildren<CardScript>().faceIndex = faceindexes[shuffleNumber];


            text = temp.GetComponentInChildren<TextMeshProUGUI>();
            string num = faceindexes[shuffleNumber].ToString();
            text.SetText(num);

            faceindexes.Remove(faceindexes[shuffleNumber]);

            xPosition += 140;

            if (i == ((originalLength / 2) - 1))
            {
                xPosition = 140f;
                yPosition = 180f;
            }

        if (cardPrefab.GetComponent<CardScript>() != null)
        {

            cardPrefab.GetComponentInChildren<CardScript>().faceIndex = faceindexes[0];
            //cardPrefab.SetActive(false);
        }

        }

    }

    public bool TwoCardsUp()
    {
        bool cardsUp = false;
        if (visibleFaces[0] >= 0 && visibleFaces[1] >= 0)
        {
            cardsUp = true;
        }
        return cardsUp;
    }

    public void AddVisibleFace(int index)
    {
        if (visibleFaces[0] == -1)
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
        bool success = false;
        if (visibleFaces[0] == visibleFaces[1])
        {
            visibleFaces[0] = -1;
            visibleFaces[1] = -2;
            success = true;
        }
        return success;
    }

    private void Awake()
    {
        cardPrefab = GameObject.Find("Card Button");
    }

    void Update()
    {

    }
}
