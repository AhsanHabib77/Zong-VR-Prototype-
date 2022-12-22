using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Trigger : MonoBehaviour
{
    public bool isDestoryMe;
    public string TriggerName;

    [Header("Active Thing")]
    public bool isActiveThing;
    public GameObject activeThing;
    
    [Header("Restart Scene")]
    public bool isRestart;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TriggerName))
        {
            if (isDestoryMe)
            {
                Destroy(gameObject);
            }
            if (isActiveThing)
            {
                Destroy(other.gameObject);
                activeThing.SetActive(false);
                activeThing.SetActive(true);

                //StopCoroutine(nameof(activeThing));
                //StartCoroutine(nameof(activeThing));
            }
            if (isRestart)
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    IEnumerator Activething()
    {
        activeThing.SetActive(true);
        yield return new WaitForSeconds(5f);
        activeThing.SetActive(false);
    }
}
