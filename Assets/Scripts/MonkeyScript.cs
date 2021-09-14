using UnityEngine;
using UnityEngine.Playables;
using System.Collections;
public class MonkeyScript : MonoBehaviour
{

    public AudioSource monkeyAudio;
    public AudioClip monkeySound;
    public AudioClip gameFinished;
    public SpriteRenderer monkey;
    public GameObject gameFinishedBox;
    //private PlayableDirector playableDirector;

    void Start()
    {
      
        monkeyAudio.GetComponent<AudioSource>();
        //playableDirector = GetComponent<PlayableDirector>();
        monkey = GetComponent<SpriteRenderer>();
        gameFinishedBox.GetComponent<GameObject>();
        gameFinishedBox.SetActive(false);
    }

    IEnumerator WaitSoundToFinish()
    {
        monkeyAudio.PlayOneShot(monkeySound);
        monkey.enabled = true;


        yield return new WaitWhile(() => monkeyAudio.isPlaying);

        monkeyAudio.PlayOneShot(gameFinished, 0.4f);
    }
    public void MonkeySound()
    {

        if (monkey.enabled == false)
        {
            gameFinishedBox.SetActive(true);
            StartCoroutine(WaitSoundToFinish());

        }

    }

    public void playMonkeyAnimation() 
    {
/*         Debug.Log("playMonkeyAnimation mark reached");
        playableDirector = GetComponent<PlayableDirector>();
        //playableDirector.Stop();
        monkey = GetComponent<SpriteRenderer>();
        if(monkey.enabled == true)
        {

            playableDirector.Play();
            Debug.Log("Started monkey animation");
        }
        else
        {
            playableDirector.Stop();
        } */
    }

    void Update()
    {
       
    }
}
