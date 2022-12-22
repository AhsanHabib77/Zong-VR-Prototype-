using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvusManager : MonoBehaviour
{
    public GameObject ball;
    public Transform ballSpawnPoint;
    
    public void SpawnBall()
    {
        Instantiate(ball, ballSpawnPoint.position, ballSpawnPoint.rotation);
    }
}
