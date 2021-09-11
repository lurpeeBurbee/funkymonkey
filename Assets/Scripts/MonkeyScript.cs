using UnityEngine;
using UnityEngine.Playables;
public class MonkeyScript : MonoBehaviour
{

    public AudioSource monkeyAudio;
    public AudioClip monkeySound;
    public SpriteRenderer monkey;
    private PlayableDirector playableDirector;

    void Start()
    {
      
        monkeyAudio.GetComponent<AudioSource>();

        monkey = GetComponent<SpriteRenderer>();
    }

    public void MonkeySound()
    {

        if (monkey.enabled == false)
        {
            monkeyAudio.PlayOneShot(monkeySound);
            monkey.enabled = true;

        }

    }

    public void playMonkeyAnimation() 
    {
        playableDirector = GetComponent<PlayableDirector>();
        playableDirector.Stop();
        monkey = GetComponent<SpriteRenderer>();
        if(monkey.enabled == true)
        {

            playableDirector.Play();
            Debug.Log("Started monkey animation");
        }
        else
        {
            playableDirector.Stop();
        }
    }

    void Update()
    {
       
    }
}
