using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSimple : MonoBehaviour
{
    [Header("Item")]
    public GameObject Key;
    public GameObject Hammer;

    [Header("Player")]
    public GameObject Orientation;
    
        PlayerMovementTutorial PlayerController;
    
    void Update()
    {
        PlayerController = GameObject.Find("Player").GetComponent<PlayerMovementTutorial>();
        if (Input.GetKeyDown(KeyCode.Q) && PlayerController.Key == true)
        {
            Instantiate(Key, Orientation.transform.position + (Orientation.transform.forward * 0.5f), Orientation.transform.rotation);
            Debug.Log("Drop Key");
            PlayerController.Key = false;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && PlayerController.Hammer == true)
        {
            Instantiate(Hammer, Orientation.transform.position + (Orientation.transform.forward * 0.5f), Orientation.transform.rotation);
            Debug.Log("Drop Hammer");
            PlayerController.Hammer = false;
        }
    }
}
