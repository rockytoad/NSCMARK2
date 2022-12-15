using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryCondition : MonoBehaviour
{
    public void OnTriggerStay(Collider other)
    {
        // Check if the object that entered the trigger is the player
        if (other.gameObject.tag == "VictoryPoint")
        {
            // Get the PlayerController component from the player
            PlayerMovementTutorial playerController = gameObject.GetComponent<PlayerMovementTutorial>();
            Scores score = gameObject.GetComponent<Scores>();

            if (Input.GetKeyDown(KeyCode.E))
            {
                // Set the player's speed to 0 to disable movement
                score.score += 100;
                playerController.isSafe = true;
                playerController.moveSpeed = 0;
                other.enabled = false;
            }

        }
    }
    //void OnTriggerEnter(Collider other)
    //{
    //    // Check if the object that entered the trigger is the player
    //    if (other.gameObject.tag == "VictoryPoint")
    //    {
    //        // Get the PlayerController component from the player
    //        PlayerMovementTutorial playerController = gameObject.GetComponent<PlayerMovementTutorial>();

    //        if (Input.GetKeyDown(KeyCode.E))
    //        {
    //            // Set the player's speed to 0 to disable movement
    //            playerController.moveSpeed = 0;
    //        }
    //    }
    //}
}
