using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneHandler : MonoBehaviour
{
    public Transform target;
    public float step = 5f;
    public bool inHand;
    public GameObject particleEffect;

    // Update is called once per frame
    void Update()
    {
        if (!inHand)
        {
            if (transform.position != target.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            }
            else
            {
                inHand = true;
                particleEffect.SetActive(true);
                GetComponent<Rigidbody>().isKinematic = true;
            }
        }
    }

    public void Release()
    {
        inHand = false;
    }
}
