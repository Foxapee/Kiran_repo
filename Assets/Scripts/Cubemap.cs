using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxRotation : MonoBehaviour
{
    public float rotationSpeed = 1.0f; // Speed of rotation in degrees per second

    void Update()
    {
        // Get the current rotation value of the skybox
        float currentRotation = RenderSettings.skybox.GetFloat("_Rotation");

        // Calculate the new rotation based on time
        float rotation = rotationSpeed * Time.deltaTime;

        // Update the skybox's rotation value
        float newRotation = currentRotation + rotation;
        RenderSettings.skybox.SetFloat("_Rotation", newRotation);

        // Debugging: Log the updated rotation value
        Debug.Log("Skybox Rotation: " + newRotation);
    }
}