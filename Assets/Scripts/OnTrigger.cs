using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public AudioSource audioSource;

    public void OnTriggerEnter(Collider other)
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }

        else
        {
            audioSource.UnPause();
        }
    }

}
