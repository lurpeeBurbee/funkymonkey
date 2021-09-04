using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public GameObject audioManager;
    public Sound[] spokenSounds;
    public Sound[] playedSounds;
    public AudioSource source;
    public AudioClip clip;
    public GameObject backSideVisible;
    bool canPlay = false;

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

        backSideVisible.GetComponent<MainToken>().BackSideVisible();

    }

    public void PlaySpokenSound()
    {

        if (backSideVisible)
            print("backSideVisible == true");
        {
            if (!source.isPlaying)
            {
                source.PlayOneShot(clip, 0.4f);
            }
            else
            {
                source.Stop();
                source.PlayOneShot(clip, 0.4f);
            }
        }
    }

    public void PlayPlayedSound()
    {
        if (!source.isPlaying)
        {
            //source.PlayOneShot(clip, 0.1f);
        }
    }
    public void Play(string name)
    {



    }
}
