using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class MainToken : MonoBehaviour
{
    private Button thiscard;
    public object[] card;
    GameObject objects;
    GameObject gameControl;
    Image img;
    public Sprite[] faces;
    public Sprite back;
    public int faceIndex;
    public bool matched = false;
    public bool twoCardsUp;
    public GameObject gameCanvas;
    public TextMeshProUGUI points;
    private int score = 0;

    public bool BackSideVisible()
    {
        if (img.sprite == back)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void OnMouseDown()
    {
        print("2 cards up is " + twoCardsUp);

        if (matched == false)
        {
            //GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>().source.Stop();

            //print("match is false");

            if (img.sprite == back)
            {
                //print("img.sprite == back");
                if (gameControl.GetComponent<GameControl>().TwoCardsUp() == false)

                {
                    //print("TwoCardsUp == false");

                    img.sprite = faces[faceIndex];
                    gameControl.GetComponent<GameControl>().AddVisibleFace(faceIndex);
                    matched = gameControl.GetComponent<GameControl>().CheckMatch();

                    if (matched)
                    {
                        print("MATCH is " + matched);
                        score += 1;
                        points.text = score.ToString();


                        foreach (Button o in card)
                        {
                            print("cards length: " + card.Length);
                            if (o.CompareTag("Card") && o.image.sprite != back)
                            {
                                Debug.Log("------Open card: " + o);
                                o.interactable = false;
                            }
                        }
                    }
                }
            }
            else
            {
                img.sprite = back;
                gameControl.GetComponent<GameControl>().RemoveVisibleFace(faceIndex);
            }
        }
        else
        {
            //button = false;
            thiscard.interactable = false;
            Debug.Log("Can't turn the card anymore");
            img.sprite = faces[faceIndex];
        }
        print("BackSideVisible: " + BackSideVisible());
        Debug.Log("pairs found: " + score);
    }
    private void Start()
    {
        points.text = score.ToString();
    }
    private void Awake()
    {
        thiscard = GetComponent<Button>();

        card = FindObjectsOfType(typeof(Button));
        gameControl = GameObject.Find("GameControl");
        img = GetComponent<Image>();
        img.sprite = back;
        matched = gameControl.GetComponent<GameControl>().CheckMatch();
        twoCardsUp = gameControl.GetComponent<GameControl>().TwoCardsUp();
        points.GetComponent<TMPro.TextMeshProUGUI>();







    }

    private void Update()
    {


        //points.text = score.ToString();

    }

}

