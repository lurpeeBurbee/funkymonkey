using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class relaxedGameplay : MonoBehaviour
{
    public GameObject cardPrefab;
    public GameObject Cards;
    public Sprite newImage;
    GameObject spawnedCard;


    SpriteRenderer spriteRenderer;
    public Sprite[] faces;
    public Sprite back;
    public int faceIndex;

    GameObject firstLine;
    GameObject secondLine;
    GameObject thirdLine;

    public void OnMouseDown()
    {
        if(spriteRenderer.sprite == back)
        {
            spriteRenderer.sprite = faces[0];
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
        //imagePlaceholder = cardPrefab.GetComponentInChildren<Image>();
        //imagePlaceholder.color = Color.red;

        for (int i = 1; i < 4; i++)
        {
            firstLine = Instantiate<GameObject>(cardPrefab, new Vector3(i * 140.0f, 500, 0), Quaternion.identity, Cards.transform);
            secondLine = Instantiate<GameObject>(cardPrefab, new Vector3(i * 140.0f, 300, 0), Quaternion.identity, Cards.transform);
            thirdLine = Instantiate<GameObject>(cardPrefab, new Vector3(i * 140.0f, 100, 0), Quaternion.identity, Cards.transform);
        }

        //imagePlaceholder = firstLine.GetComponentInChildren<Image>();

        //for (int i = 1; i < 4; i++)
        //{  
        //    firstLine.SetActive(false);
        //}
        //Cards = GetComponent<GameObject>();
        
        //imagePlaceholder.color = Color.red;

        }


    void Update()
    {
        
    }
}
