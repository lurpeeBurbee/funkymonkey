using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideMonkeyhead : MonoBehaviour
{
    public GameObject monkeyHead;
    void Start()
    {
        monkeyHead.GetComponent<GameObject>();
    }
    public void ShowMonkeyHead()
    {
        monkeyHead.SetActive(true);
    }
    public void HideMonkeyHead()
    {
        monkeyHead.SetActive(false);
    }
}
