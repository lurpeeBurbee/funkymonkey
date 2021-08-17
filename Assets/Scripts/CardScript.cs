using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    GameObject GameControl;
    SpriteRenderer spriteRenderer;
    public Sprite[] faces;
    public Sprite back;
    public int faceIndex;
    public bool matched = false;

    public void OnMouseDown()
    {
        if (matched == false)
        {
            if (spriteRenderer.sprite == back)
            {
                if (GameControl.GetComponent<GameplayRelaxed>().TwoCardsUp() == false)
                {
                    spriteRenderer.sprite = faces[faceIndex]; // Now the image changes each time when clicking
                    matched = GameControl.GetComponent<GameplayRelaxed>().CheckMatch();
                    spriteRenderer.size += new Vector2(100f, 200f);
                }
            }
            else
            {
                spriteRenderer.sprite = back;
                GameControl.GetComponent<GameplayRelaxed>().RemoveVisibleFace(faceIndex);
            }
        }
    }

    private void Awake()
    {
        GameControl = GameObject.Find("GameControl");
        spriteRenderer = GetComponent<SpriteRenderer>();

       
    }
    void Start()
    {

    }

    void Update()
    {
        
    }
}
