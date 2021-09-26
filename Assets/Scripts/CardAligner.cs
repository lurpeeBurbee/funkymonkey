using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardAligner : MonoBehaviour
{
    public Canvas mainCanvas;

    void Awake()
    {
        int cardAmount = CardAmountData.cardAmount;

        mainCanvas.GetComponent<GridLayoutGroup>().constraintCount = cardAmount / 2;
        
        if(cardAmount > 10)
        {
            mainCanvas.GetComponent<GridLayoutGroup>().spacing = new Vector2(200f, 234f);
        }
    }


}
