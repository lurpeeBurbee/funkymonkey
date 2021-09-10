using UnityEngine;

public class MonkeyScript : MonoBehaviour
{
    public AudioSource monkeyAudio;
    public AudioClip monkeySound;
    public SpriteRenderer monkey;

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

    void Update()
    {
        //MonkeySound();
    }
}
