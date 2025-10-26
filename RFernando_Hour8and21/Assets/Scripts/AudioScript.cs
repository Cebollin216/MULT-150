using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        // Link this script to the AudioSource on same GameObject
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Detect Z key pressed down once
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // Toggle: if playing, stop; if stopped, play
            if (audioSource.isPlaying)
                audioSource.Stop();
            else
                audioSource.Play();
        }
    }
}
