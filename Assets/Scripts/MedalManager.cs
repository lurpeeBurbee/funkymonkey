using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalManager : MonoBehaviour
{
    public static int cardAmount;
    public static bool hasPlayed;
    public GameObject monkeyMedalHead;

    void Start()
    {
        if(SceneChanger.clearMedals == true)
        {
            monkeyMedalHead.SetActive(false);
        }

        if(hasPlayed == true && ChooseCardAmount.cardsAmountForMedal == 6)
        {
            monkeyMedalHead.SetActive(true);
        }

        print(SceneChanger.clearMedals);
    }

    void Update()
    {
        
    }
}
