using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour
{
    public bool timeisRunning = false;
    public float totalTime = 20f;
    float time = 0;
    [Header("Directional Light Things")]
    public Color Lightcolor;
    public Color startColor;
    public Light directionalLight;
    // Update is called once per frame
    void Update()
    {
        float t = Mathf.PingPong(Time.time, totalTime) / totalTime;
        directionalLight.color = Color.Lerp(startColor, Lightcolor, t); ;
        if (timeisRunning)
        {
            if (time <= 1.2)
            {
                time += Time.deltaTime / totalTime;
                
                //RenderSettings.skybox.SetFloat("_Intensity Multiplier", 1f);

                RenderSettings.skybox.SetFloat("_Exposure", time);
                //RenderSettings.ambientSkyColor = color ;
            }
            else
            {
            Debug.Log("hahahahahah");
                timeisRunning = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timeisRunning = true;
            Debug.Log("trigger");
        }
    }
}
