using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Scores : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreText;
    public int score = 0;
    private void Update()
    {
        scoreText.text = "Score: " + score;
    }
    //void OnTriggerEnter(Collider other)
    //{
    //    // Check if the object that entered the trigger is the player
    //    if (other.gameObject.tag == "VictoryPoint")
    //    {
    //        // Update the score text
    //        scoreText.text = "Score: "+ score;
    //    }
    //}
}
