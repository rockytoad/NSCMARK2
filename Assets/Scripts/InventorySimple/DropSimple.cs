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

    [SerializeField] bool isCooldown = false;
        PlayerMovementTutorial PlayerController;
    
    void Update()
    {
        PlayerController = GameObject.Find("Player").GetComponent<PlayerMovementTutorial>();
        if (Input.GetKeyDown(KeyCode.Q) && PlayerController.Key == true && isCooldown == false)
        {
            Instantiate(Key, Orientation.transform.position + (Orientation.transform.forward * 0.5f), Orientation.transform.rotation);
            Debug.Log("Drop Key");
            PlayerController.Key = false;
            StartCoroutine(Delay());
        }
        else if (Input.GetKeyDown(KeyCode.Q) && PlayerController.Hammer == true && isCooldown == false)
        {
            Instantiate(Hammer, Orientation.transform.position + (Orientation.transform.forward * 0.5f), Orientation.transform.rotation);
            Debug.Log("Drop Hammer");
            PlayerController.Hammer = false;
        }
    }

    IEnumerator Delay()
    {
        isCooldown = true;
        yield return new WaitForSeconds(3f);
        isCooldown = false;
    }
}
