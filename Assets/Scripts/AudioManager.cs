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

    bool twocards;
    bool backside;

    int spriteIndex;

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

        voiceSource = audioManager.GetComponent<AudioSource>();
        playSource = audioManager.GetComponent<AudioSource>();

        //playclip = playSource.GetComponent<AudioManager>();

        backside = backSideVisible.GetComponent<MainToken>().BackSideVisible();
        //twocardsup = GameObject.GetComponent<MainToken>().twoCardsUp;

    }
    public void PlaySpokenSound()
    {
        Debug.Log("AudioManager checks the match: " + match);
        //source.Stop();
        if (backside == true && !twocards)
        {
            //Debug.Log("backSideVisible == " + backside);
            spriteIndex = twocardsup.GetComponent<MainToken>().faceIndex;
            voiceclip = spokenSounds[spriteIndex].clip;

            if (!voiceSource.isPlaying)
            {
                voiceSource.PlayOneShot(voiceclip, 0.5f);
            
            }
            else
            {
                voiceSource.Stop();
                voiceSource.PlayOneShot(voiceclip, 0.5f);
            
            }
            
            //else
            //{
            //    voiceSource.Stop();

            //    twocards = twocardsup.GetComponent<MainToken>().twoCardsUp;
            //    if (twocards)
            //    {
            //        voiceSource.Stop();
            //        //voiceSource.PlayOneShot(voiceclip, 0.5f);
            //        Debug.Log("---------THIS SHOULD NOT HAPPEN!!!");
            //    }
            //}
        }

        if(match)
        {
            voiceSource.Stop();
        }
    }
    public void PlayPlayedSound()
    {
        match = twocardsup.GetComponent<MainToken>().matched;

        if (match == true)
        {
            voiceSource.Stop();
            playclip = playedSounds[spriteIndex].clip;
            playSource.PlayOneShot(playclip, 0.5f);
        }
    }
    public void Play(string name)
    {



    }
}
