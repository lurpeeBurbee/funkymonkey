using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public GameObject audioManager;
    public Sound[] spokenSounds;
    public Sound[] playedSounds;
    public AudioSource voiceSource;
    public AudioSource playSource;
    public AudioClip voiceclip;
    public AudioClip playclip;
    public GameObject backSideVisible;
    public GameObject twocardsup;
    bool backside;
    public bool match;
    //bool canPlay = false;

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
        //audioManager.GetComponent<GameObject>();
        voiceSource = audioManager.GetComponent<AudioSource>();
        playSource = audioManager.GetComponent<AudioSource>();
        backside = backSideVisible.GetComponent<MainToken>().BackSideVisible();
        //twocards = backSideVisible.FindGame<GameControl>().twoCardsUp();
        match = twocardsup.GetComponent<GameControl>().CheckMatch();
    }
    public void PlaySpokenSound()
    {
        //source.Stop();
        if (backside == true)
        //Debug.Log("backSideVisible == " + backside);
        {
            if (!voiceSource.isPlaying)
            {
                voiceSource.PlayOneShot(voiceclip, 0.4f);


            }
            else
            {
                voiceSource.Stop();
                //source.PlayOneShot(clip, 0.4f);
            }
        }
        else
        {
            Debug.Log("MATCCHCHCH!-play the playsound!");
            playSource.PlayOneShot(playclip, 0.5f);
        }
    }

    public void PlayPlayedSound()
    {
        if (match == true)
        {


        }

    }
    public void Play(string name)
    {



    }
}
