using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relaxedGameplay : MonoBehaviour
{
    public GameObject cardPrefab;
    public GameObject Cards;
    public Sprite newImage;



    void Start()
    {
        for (int i = 1; i < 4; i++)
        {
            Instantiate<GameObject>(cardPrefab, new Vector3(i * 140.0f, 500, 0), Quaternion.identity, Cards.transform);
            Instantiate<GameObject>(cardPrefab, new Vector3(i * 140.0f, 300, 0), Quaternion.identity, Cards.transform);
            Instantiate<GameObject>(cardPrefab, new Vector3(i * 140.0f, 100, 0), Quaternion.identity, Cards.transform);
        }
    }


    void Update()
    {
        
    }
}
