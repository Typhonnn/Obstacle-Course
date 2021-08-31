using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    private int hits = 0;
    public Text score;

    private void OnCollisionEnter(Collision other)
    {
        // score increases only for first hit of obstacle
        if (!other.gameObject.CompareTag("IsHit") && !other.gameObject.CompareTag("Finish"))
        {
            hits++;
        }
        // when reached the end turn off player object
        else if (other.gameObject.CompareTag("Finish"))
        {
            this.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        score.text = "Obstacles Hit: " + hits;
    }
}
