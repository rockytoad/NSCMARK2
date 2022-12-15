using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Tsunami : MonoBehaviour
{
    public GameObject Deadscore;
    public float speed = 0.5f;
    public Transform target;
    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Get the PlayerController component from the player
            PlayerMovementTutorial playerController = gameObject.GetComponent<PlayerMovementTutorial>();
            // Set the player's speed to 0 to disable movement
            Destroy(other.gameObject);
            Deadscore.gameObject.SetActive(true);
            
        }
        if (other.gameObject.tag == "AI")
        {
            Destroy(other.gameObject);
        }
    }
}
