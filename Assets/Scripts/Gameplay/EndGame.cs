using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    public GameObject EndSafe;
    public GameObject EndFail;
    PlayerMovementTutorial PlayerController;
    Scores score;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            Debug.Log("Hit End");
            // Get the PlayerController component from the player
            PlayerController = GameObject.Find("Player").GetComponent<PlayerMovementTutorial>();
            score = GameObject.Find("Player").GetComponent<Scores>();
            if (PlayerController.isSafe == true)
            {
                score.score += 500;
                Debug.Log("Hit End");
                StartCoroutine(delay1());
            }
            else if(PlayerController.isSafe == false)
            {
                StartCoroutine(delay2());
            }

        }
    }

    IEnumerator delay1()
    {
        EndSafe.gameObject.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        EndSafe.gameObject.SetActive(false);
    }
    IEnumerator delay2()
    {
        EndFail.gameObject.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        EndFail.gameObject.SetActive(false);
    }
}
