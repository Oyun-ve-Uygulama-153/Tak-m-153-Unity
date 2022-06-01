using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlightController : MonoBehaviour
{

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x,
                                        transform.position.y + speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime,
                                        transform.position.y);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x,
                                        transform.position.y - speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime,
                                        transform.position.y);
        }
    }
}
