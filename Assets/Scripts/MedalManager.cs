using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalManager : MonoBehaviour
{
    public static int cardAmount;
    public static bool hasPlayed;
    public GameObject monkeyMedalHead1;
    public GameObject monkeyMedalHead2;
    public GameObject monkeyMedalHead3;

    void Start()
    {
        monkeyMedalHead1.SetActive(false);
        monkeyMedalHead2.SetActive(false);
        monkeyMedalHead3.SetActive(false);

        Debug.Log(SceneChanger.clearMedals);
        Debug.Log(ChooseCardAmount.cardsAmountForMedal);

        if (SceneChanger.clearMedals == true)
        {
            monkeyMedalHead1.SetActive(false);
            monkeyMedalHead2.SetActive(false);
            monkeyMedalHead3.SetActive(false);
        }

        if(hasPlayed == true && ChooseCardAmount.cardsAmountForMedal == 6)
        {
            monkeyMedalHead1.SetActive(true);
            //monkeyMedalHead2.SetActive(false);
           // monkeyMedalHead3.SetActive(false);
        }

        if (hasPlayed == true && ChooseCardAmount.cardsAmountForMedal == 8)
        {
            monkeyMedalHead2.SetActive(true);
        }
        if (hasPlayed == true && ChooseCardAmount.cardsAmountForMedal == 12)
        {
            monkeyMedalHead3.SetActive(true);
        }
    }
    void ControlOtherMedals(int cardAmount)
    {

    }

    void Update()
    {
        
    }
}
