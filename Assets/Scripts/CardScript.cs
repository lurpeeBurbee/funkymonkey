using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    public GameObject card;

    public void flipCard()
    {
        card.GetComponent<GameObject>().transform.position = new Vector3(100, 200, 0);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
