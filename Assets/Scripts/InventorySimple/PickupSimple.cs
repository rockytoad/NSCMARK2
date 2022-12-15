using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSimple : MonoBehaviour
{
    PlayerMovementTutorial PlayerController;
    void OnTriggerEnter(Collider other)
    {
        // Check if the other collider is the player's character.
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Hit Items");
            Destroy(gameObject);
        }
    }
    void OnTriggerStay(Collider other)
    {
        // Check if the other collider is the player's character.
        if (other.gameObject.tag == "Player")
        {
            PlayerController = GameObject.Find("Player").GetComponent<PlayerMovementTutorial>();
            Debug.Log("Hit Items");
            Destroy(gameObject);
            PlayerController.Key = true;

        }
    }


}
