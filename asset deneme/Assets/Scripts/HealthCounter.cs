using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCounter : MonoBehaviour
{
    public static int Health = 3;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Health")

        {
            Health++;
            Destroy(other.gameObject);
            Debug.Log(Health);
        }

    }

    public int GetHealth()
    {
        return Health;
    }

    public void AttackPlayer(int AttackPower)
    {
        Health -= AttackPower;
    }
}
