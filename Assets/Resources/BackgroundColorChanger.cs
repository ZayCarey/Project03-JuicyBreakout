using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColorChanger : MonoBehaviour
{
    private Camera mainCamera;
    private int currentLevel = 1;

    void Start()
    {
        mainCamera = Camera.main; 
        ChangeBackgroundColor(Color.blue);
    }

    void Update()
    {
        if (Time.time > 10 * currentLevel)
        {
            currentLevel++;
            ChangeBackgroundColor(Random.ColorHSV());
        }
    }

    private void ChangeBackgroundColor(Color newColor)
    {
        mainCamera.backgroundColor = newColor;
    }
}