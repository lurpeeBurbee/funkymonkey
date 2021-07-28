using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayRelaxed : MonoBehaviour
{
    public GameObject cardPrefab;
    List<int> faceindexes = new List<int> { 0, 1, 2, 3, 0, 1, 2, 3 };
    public static System.Random rnd = new System.Random();
    public int shuffleNumber = 0;
    int[] visibleFaces = { -1, -2 };

    public GameObject Cards;

    GameObject spawnedCard;

    GameObject firstLine;
    GameObject secondLine;
    GameObject thirdLine;

    Bounds bounds;
    float spriteSize;
    

    void Start()
    {
        int originalLength = faceindexes.Count;
        //Cards.GetComponent<GameObject>().transform.position = new Vector3(100, 200, 0);
        //imagePlaceholder = cardPrefab.GetComponentInChildren<Image>();
        //imagePlaceholder.color = Color.red;

        for (int i = 1; i < 4; i++)
        {
            shuffleNumber = rnd.Next(0, (faceindexes.Count));

            firstLine = Instantiate<GameObject>(cardPrefab, new Vector3(i * 140.0f, 500, 0), Quaternion.identity, Cards.transform);
            secondLine = Instantiate<GameObject>(cardPrefab, new Vector3(i * 140.0f, 300, 0), Quaternion.identity, Cards.transform);
            thirdLine = Instantiate<GameObject>(cardPrefab, new Vector3(i * 140.0f, 100, 0), Quaternion.identity, Cards.transform);

            firstLine.GetComponent<CardScript>().faceIndex  = faceindexes[shuffleNumber];
            secondLine.GetComponent<CardScript>().faceIndex = faceindexes[shuffleNumber];
            thirdLine.GetComponent<CardScript>().faceIndex = faceindexes[shuffleNumber];


            faceindexes.Remove(faceindexes[shuffleNumber]);
            //bounds = cardPrefab.gameObject.GetComponentInChildren<SpriteRenderer>().sprite.bounds;
            //spriteSize = bounds.size.x;
            //Debug.Log(bounds.size);
            //Debug.Log(spriteSize);
            //spriteSize = 0.4f;

        }

        //imagePlaceholder = firstLine.GetComponentInChildren<Image>();

        //for (int i = 1; i < 4; i++)
        //{  
        //    firstLine.SetActive(false);
        //}
        //Cards = GetComponent<GameObject>();

        //imagePlaceholder.color = Color.red;

    }


    void Update()
    {

    }
}
