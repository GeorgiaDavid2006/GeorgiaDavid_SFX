using UnityEngine;

public class AudioController : MonoBehaviour
{
    public GameObject backgroundMusicPlayer;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = backgroundMusicPlayer.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource.Pause();
            Debug.Log("Music paused");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource.UnPause();
            Debug.Log("Music unpaused");
        }
    }
}
