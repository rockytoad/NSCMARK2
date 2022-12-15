using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject Keyneed;

    public GameObject Hammerneed;

    public GameObject Ladderneed;

    public GameObject TargetCube = null;

    public GameObject Player = null;

    private bool startTeleport = false;

    public float State;

    PlayerMovementTutorial PlayerController;
    Scores score;
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
        PlayerController = GameObject.Find("Player").GetComponent<PlayerMovementTutorial>();
        score = GameObject.Find("Player").GetComponent<Scores>();
        if (State == 0 && other.gameObject.tag == "Player")
        {
            startTeleport = true;
        }

        else if (State == 1 && other.gameObject.tag == "Player")
        {
            if (PlayerController.Key == true)
            {
                score.score += 50;
                startTeleport = true;
                PlayerController.Key = false;
            }
            else if(PlayerController.Key == false)
            {
                StartCoroutine(Delay1());               
            }
        }
        else if (State == 2 && other.gameObject.tag == "Player")
        {
            if (PlayerController.Hammer == true)
            {
                score.score += 50;
                startTeleport = true;
                PlayerController.Hammer = false;
            }
            else if (PlayerController.Hammer == false)
            {
                StartCoroutine(Delay2());
            }
        }
        else if (State == 3 && other.gameObject.tag == "Player")
        {
            if (PlayerController.Ladder == true)
            {
                score.score += 50;
                startTeleport = true;
                PlayerController.Ladder = false;
            }
            else if (PlayerController.Ladder == false)
            {
                StartCoroutine(Delay3());
            }
        }
    }
    IEnumerator Delay1()
    {
        Keyneed.gameObject.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        Keyneed.gameObject.SetActive(false);
    }
    IEnumerator Delay2()
    {
        Hammerneed.gameObject.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        Hammerneed.gameObject.SetActive(false);
    }
    IEnumerator Delay3()
    {
        Ladderneed.gameObject.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        Ladderneed.gameObject.SetActive(false);
    }
}
