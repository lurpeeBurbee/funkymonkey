using UnityEngine;

public class MedalManager : MonoBehaviour
{
    public static int cardAmount;
    public static bool hasPlayed; // Where does this come from?

    public GameObject monkeyMedalHead1;
    public GameObject monkeyMedalHead2;
    public GameObject monkeyMedalHead3;


    void Start()
    {

        //monkeyMedalHead1.SetActive(false);
        //monkeyMedalHead2.SetActive(false);
        //monkeyMedalHead3.SetActive(false);


        Debug.Log(ChooseCardAmount.cardsAmountForMedal);

        //if (GlobalScript.hideAllMedals == true)
        //{
        //    monkeyMedalHead1.SetActive(false);
        //    monkeyMedalHead2.SetActive(false);
        //    monkeyMedalHead3.SetActive(false);
        //}
        if (GlobalScript.hideAllMedals != true)
        {
            if (hasPlayed == true && ChooseCardAmount.cardsAmountForMedal == 6)
            {
                monkeyMedalHead1.SetActive(true);

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
    }

    public void HideAllMedals()
    {
        if (GlobalScript.hideAllMedals == true)
        {
            monkeyMedalHead1.SetActive(false);
            monkeyMedalHead2.SetActive(false);
            monkeyMedalHead3.SetActive(false);
 
        }


    }

    void Update()
    {

    }
}
