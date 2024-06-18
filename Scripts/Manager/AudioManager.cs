using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource source;
   
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.Play();
    }
}
