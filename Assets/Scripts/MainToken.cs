using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainToken : MonoBehaviour
{
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
        if (matched)
        {
            button = false;
            print("button is false");
                //img.sprite = faces[faceIndex];
        }
    }

    private void Awake()
    {
        gameControl = GameObject.Find("GameControl");
        img = GetComponent<Image>();
        img.sprite = back;
        matched = gameControl.GetComponent<GameControl>().CheckMatch();
        twoCardsUp = gameControl.GetComponent<GameControl>().TwoCardsUp();
        button = GetComponent<Button>().IsInteractable();

    }
}
