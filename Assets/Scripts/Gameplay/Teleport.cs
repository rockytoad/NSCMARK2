using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject TargetCube = null;

    public GameObject Player = null;

    private bool startTeleport = false;

    public float State;


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

        else if(State == 1)
        {
            if ()
            {

            }
        }
    }
}
