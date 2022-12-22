using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClip : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Foot"))
        {
           audioSource.Play();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.transform.CompareTag("Foot"))
        {
            audioSource.Play();
        }
    }
}
