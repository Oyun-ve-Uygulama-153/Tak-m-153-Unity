using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetNextLevel : MonoBehaviour
{
    public float NextLevelSceneNumber = 0f; 
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Next Level!: " + NextLevelSceneNumber);
    }
}
