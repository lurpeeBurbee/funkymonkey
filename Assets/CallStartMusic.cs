using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallStartMusic : MonoBehaviour
{
   
    void Start()
    {
        GameObject.FindGameObjectWithTag("StartMusic").GetComponent<StartMusic>().PlayStartMusic();
    }


}
