using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RuleController : MonoBehaviour
{
    private static RuleController instance = null;
    public static RuleController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new RuleController();
            }
            return instance;
        }
    }
    public 
    HealthCounter PlayerHealthCounter;


    // Update is called once per frame
    void FixedUpdate()
    {
        if(PlayerHealthCounter.GetHealth() < 1)
        {
            SceneManager.LoadScene(6);
        }
    }
}
