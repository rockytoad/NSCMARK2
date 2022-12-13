using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Vector3 targetPosition; // The target position for the teleport

    void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger is the player
        if (other.gameObject.tag == "Player")
        {
            // Teleport the object to the target position
            other.transform.position = targetPosition;
        }
    }
}
