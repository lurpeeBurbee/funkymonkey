using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class GameplayRelaxed : MonoBehaviour
{
    public GameObject Cards;
    public GameObject cardPrefab;
    List<int> faceindexes = new List<int> { 0, 1, 2, 3, 0, 1, 2, 3 };
    public static System.Random rnd = new System.Random();
    public int shuffleNumber = 0;
    readonly int[] visibleFaces = { -1, -2 };

    public TextMeshProUGUI text;

    void Start()
    {

        int originalLength = faceindexes.Count;

        //Cards.GetComponent<GameObject>().transform.position = new Vector3(100, 200, 0);
        //imagePlaceholder = cardPrefab.GetComponentInChildren<Image>();
        //imagePlaceholder.color = Color.red;
        float yPosition = 400f;
        float xPosition = 140f;

        for (int i = 0; i < 8; i++)
        {
            shuffleNumber = rnd.Next(0, (faceindexes.Count));

            var temp = Instantiate<GameObject>(cardPrefab, new Vector3(xPosition, yPosition, 0), Quaternion.identity, Cards.transform);

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


        }

        cardPrefab.SetActive(false);
    }

    private void Awake()
    {
        cardPrefab = GameObject.Find("Card Button");
    }

    void Update()
    {

    }
}
