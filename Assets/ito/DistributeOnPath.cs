using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class DistributeOnPath : MonoBehaviour
{
    public GameObject obstacle;
    public PathCreator pc;    
    public float distanceBetween = 20;
    public int numberObstacles = 10;

    private void Start()
    {
        for (int i = 1; i <= numberObstacles; i++)
        {
            obstacle.transform.position = pc.path.GetPointAtDistance(i * distanceBetween);
            obstacle.transform.rotation = pc.path.GetRotationAtDistance(i * distanceBetween);

            Instantiate(obstacle, obstacle.transform.position + new Vector3(0, 0.3f, 0), obstacle.transform.rotation);
        }
    }
    void Update()
    {
        
    }
}
