using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    public GameObject card;

    SpriteRenderer spriteRenderer;
    public Sprite[] faces;
    public Sprite back;
    public int faceIndex;


    public void OnMouseDown()
    {
        if (spriteRenderer.sprite == back)
        {
            spriteRenderer.sprite = faces[faceIndex++];
        }
        else
        {
            spriteRenderer.sprite = back;
        }
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = back;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
