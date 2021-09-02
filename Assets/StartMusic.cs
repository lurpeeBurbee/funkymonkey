using UnityEngine;

public class StartMusic : MonoBehaviour
{
    private AudioSource _audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayStartMusic()
    {
        if (!_audioSource.isPlaying)
        {
            _audioSource.Play();
        }

    }

    public void StopStartMusic()
    {
        _audioSource.Stop();
    }
}