using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject Keyneed;

    public GameObject TargetCube = null;

    public GameObject Player = null;

    private bool startTeleport = false;

    public float State;

    PlayerMovementTutorial PlayerController;

    // Update is called once per frame
    void Update()
    {
        if (startTeleport)
        {
            startTeleport = false;
            Player.transform.position = TargetCube.transform.position;
            float distance = Vector3.Distance(Player.transform.position, TargetCube.transform.position);

        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (State == 0)
        {
            startTeleport = true;
        }

        else if (State == 1)
        {
            PlayerController = GameObject.Find("Player").GetComponent<PlayerMovementTutorial>();
            if (PlayerController.Key == true)
            {
                startTeleport = true;
                PlayerController.Key = false;
            }
            else if(PlayerController.Key == false)
            {
                StartCoroutine(Delay());               
            }
        }
    }
    IEnumerator Delay()
    {
        Keyneed.gameObject.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        Keyneed.gameObject.SetActive(false);
    }
}
