using System.Net;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class BeepBoomSFX : MonoBehaviour
{
    float timer = 0f;

    public AudioSource beepAudio;
    public AudioSource boomAudio;

    private void OnTriggerEnter(Collider other)
    {
        timer += Time.deltaTime;

        beepAudio.Play();

        if (beepAudio.isPlaying)
        {
            Debug.Log("playing");
        }

        else
        {
            boomAudio.Play();
        }
    }


}
