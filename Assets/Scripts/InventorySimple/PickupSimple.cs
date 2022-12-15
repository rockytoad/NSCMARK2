using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSimple : MonoBehaviour
{

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
            Debug.Log("Hit Items");
            Destroy(gameObject);
        }
    }


}
