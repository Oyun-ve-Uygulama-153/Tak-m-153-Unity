using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetNextLevel : MonoBehaviour
{
    public int NextLevelSceneNumber = 0; 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "RightWall")
        {
            Debug.Log("Next Level!: " + NextLevelSceneNumber);
            SceneManager.LoadScene(NextLevelSceneNumber);
        }
        
    }
}
