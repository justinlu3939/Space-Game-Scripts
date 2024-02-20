using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetTrashScript : MonoBehaviour
{
    public Transform planetTarget;

    public float rotationSpeed = 7f;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(planetTarget.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
