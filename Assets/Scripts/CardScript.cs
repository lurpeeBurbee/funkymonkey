using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite[] faces;
    public Sprite back;
    public int faceIndex;

    public void OnMouseDown()
    {
        if (spriteRenderer.sprite == back)
        {
            spriteRenderer.sprite = faces[faceIndex]; // Now the image changes each time when clicking
            
            spriteRenderer.size += new Vector2(100f, 200f);
        }
        else
        {
            spriteRenderer.sprite = back;
        }
    }

    private void Awake()
    {    
        spriteRenderer = GetComponent<SpriteRenderer>();

       
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
