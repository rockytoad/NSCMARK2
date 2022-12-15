using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSimple : MonoBehaviour
{
    PlayerMovementTutorial PlayerController;

    void OnTriggerStay(Collider other)
    {
        PlayerController = GameObject.Find("Player").GetComponent<PlayerMovementTutorial>();
        // Check if the other collider is the player's character.
        if (other.gameObject.tag == "Key" && PlayerController.Hammer == false && PlayerController.Key == false)
        {
            //PlayerController = GameObject.Find("Player").GetComponent<PlayerMovementTutorial>();
            Debug.Log("Hit Key");
            Destroy(other.gameObject);
            PlayerController.Key = true;
        }
        else if(other.gameObject.tag == "Hammer" && PlayerController.Hammer == false && PlayerController.Key == false)
        {
            //PlayerController = GameObject.Find("Player").GetComponent<PlayerMovementTutorial>();
            Debug.Log("Hit Hammer");
            Destroy(other.gameObject);
            PlayerController.Hammer = true;
        }
    }


}
