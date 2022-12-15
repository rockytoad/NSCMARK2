using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    public GameObject EndSafe;
    PlayerMovementTutorial PlayerController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            Debug.Log("Hit End");
            // Get the PlayerController component from the player
            PlayerController = GameObject.Find("Player").GetComponent<PlayerMovementTutorial>();
            if (PlayerController.isSafe == true)
            {
                Debug.Log("Hit End");
                StartCoroutine(delay());
            }

        }
    }

    IEnumerator delay()
    {
        EndSafe.gameObject.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        EndSafe.gameObject.SetActive(false);
    }
}
