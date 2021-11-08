using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 
    ChooseCardAmount : MonoBehaviour
{
    public static int cardsAmountForMedal;

    public void SetCardAMount(int amount)
    {
        CardAmountData.cardAmount = amount;
        cardsAmountForMedal = amount;
    }
}
