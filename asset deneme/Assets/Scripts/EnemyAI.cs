using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float speed = 10f;
    public int AttackPower = 1;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime,
                                transform.position.y);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(this.name + " collide" + collision.name);
        if(collision.tag == "Player")
        {
            collision.gameObject.GetComponent<HealthCounter>().AttackPlayer(AttackPower);
            Destroy(this.gameObject);
        }
    }
}
