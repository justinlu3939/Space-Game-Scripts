using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonTrashScript : MonoBehaviour
{
    public Transform moonTarget;
    public float orbitalSpeed = 30f; // Adjust this for the desired orbital speed

    private Vector3 initialPosition;

    private void Start()
    {
        // Store the initial position relative to the moon
        initialPosition = transform.position - moonTarget.position;
    }

    void Update()
    {
        // Calculate the new position based on the moon's rotation
        Vector3 newPosition = Quaternion.Euler(0f, orbitalSpeed * Time.deltaTime, 0f) * initialPosition;
        transform.position = moonTarget.position + newPosition;

        //rotate the object on its own axis
        transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
        
        // Rotate the space trash around the moon
        //transform.RotateAround(moonTarget.position, Vector3.up, orbitalSpeed * Time.deltaTime);
    }
}