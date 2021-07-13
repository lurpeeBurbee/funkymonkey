using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayRelaxed : MonoBehaviour
{
    public GameObject cardPrefab;
    public GameObject Cards;
    //public Sprite newImage;
    GameObject spawnedCard;

    GameObject firstLine;
    GameObject secondLine;
    GameObject thirdLine;

    void Start()
    {

        //Cards.GetComponent<GameObject>().transform.position = new Vector3(100, 200, 0);
        //imagePlaceholder = cardPrefab.GetComponentInChildren<Image>();
        //imagePlaceholder.color = Color.red;

        for (int i = 1; i < 4; i++)
        {
            firstLine = Instantiate<GameObject>(cardPrefab, new Vector3(i * 140.0f, 500, 0), Quaternion.identity, Cards.transform);
            secondLine = Instantiate<GameObject>(cardPrefab, new Vector3(i * 140.0f, 300, 0), Quaternion.identity, Cards.transform);
            thirdLine = Instantiate<GameObject>(cardPrefab, new Vector3(i * 140.0f, 100, 0), Quaternion.identity, Cards.transform);
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
