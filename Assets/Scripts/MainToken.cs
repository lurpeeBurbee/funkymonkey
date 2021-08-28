using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainToken : MonoBehaviour
{
    private GameObject thiscard;
    GameObject gameControl;
    Image img;
    public Sprite[] faces;
    public Sprite back;
    public int faceIndex;
    public bool matched = false;
    public bool twoCardsUp;
    bool button;

    public void OnMouseDown()
    {
        print("match is " + matched);
        print("2 cards up is " + twoCardsUp);

        if (matched == false)
        {
            if (img.sprite == back)
            {
                if (gameControl.GetComponent<GameControl>().TwoCardsUp() == false)
                {
                    img.sprite = faces[faceIndex];
                    gameControl.GetComponent<GameControl>().AddVisibleFace(faceIndex);
                    matched = gameControl.GetComponent<GameControl>().CheckMatch();
                }
            }
            else
            {
                img.sprite = back;
                gameControl.GetComponent<GameControl>().RemoveVisibleFace(faceIndex);
            }
        }
        if (matched && twoCardsUp) {
        {
            button = false;
            //thiscard.SetActive(false);
            print("Can't turn the card anymore");
                //img.sprite = faces[faceIndex];
        }
    }
    }

    private void Awake()
    {
        // thiscard = GetComponent<GameObject>();

        gameControl = GameObject.Find("GameControl");
        img = GetComponent<Image>();
        img.sprite = back;
        matched = gameControl.GetComponent<GameControl>().CheckMatch();
        twoCardsUp = gameControl.GetComponent<GameControl>().TwoCardsUp();
        
        button = GetComponent<Button>().IsInteractable();

    }
}

