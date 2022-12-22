using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class FireBulletOnActivate : MonoBehaviour
{
    public GameObject []bullets;
    public Transform spawnPoint;
    public float fireSpeed;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireBullet(ActivateEventArgs arg)
    {
        GameObject SpawnBullet = Instantiate(bullets[Random.Range(0,bullets.Length)]);
        audioSource.Play();
        SpawnBullet.transform.position = spawnPoint.position;
        SpawnBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        Destroy(SpawnBullet, 5f);
    }
}
