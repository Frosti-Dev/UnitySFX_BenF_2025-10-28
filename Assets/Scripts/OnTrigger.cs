using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public AudioSource audioSource;

    public void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
    }

}
