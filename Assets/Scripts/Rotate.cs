using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject car; 
    public float rotationSpeed = 40f; 

    private bool isRotating = false;

    void Update()
    {
        if (isRotating)
        {
            
            car.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }

    public void ToggleRotation()
    {
        isRotating = !isRotating;
    }
}



