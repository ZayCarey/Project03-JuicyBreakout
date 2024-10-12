using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrail : MonoBehaviour
{
    private TrailRenderer trail;

    void Start()
    {
        trail = gameObject.AddComponent<TrailRenderer>();
        trail.startWidth = 0.2f;
        trail.endWidth = 0.05f;
        trail.time = 0.5f; 
        trail.startColor = Color.magenta;
    }
}