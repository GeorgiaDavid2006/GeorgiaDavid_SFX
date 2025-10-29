using UnityEngine;

public class SFXController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            audioSource.PlayOneShot(audioClip);
            Debug.Log("Clip played");
        }
    }
}
