using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public GameObject audioManager;
    public Sound[] spokenSounds;
    public Sound[] playedSounds;
    public AudioSource source;
    public AudioClip clip;

    void Start()
    {
        //foreach (Sound s in spokenSounds)
        //{
        //    //gameObject.AddComponent<AudioSource>();
        //    source = GetComponent<AudioSource>();
        //    source.clip = s.clip;

        //    s.source.volume = s.volume;
        //    s.source.pitch = s.pitch;

        //}
        audioManager.GetComponent<GameObject>();
        source = audioManager.GetComponent<AudioSource>();

    }

    public void playSpokenSound()
    {
        source.PlayOneShot(clip, 0.1f);
    }
    public void Play(string name)
    {



    }
}
