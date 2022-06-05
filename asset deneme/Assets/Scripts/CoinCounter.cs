using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{

    public static int score = 0;


    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Coin")

        {
            score++;
            Destroy(other.gameObject);
            Debug.Log(score);
        }

    }

    public int GetScore()
    {
        return score;
    }

    public void ResetScore()
    {
        score = 0;
    }
}
