using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class StartScreenController : MonoBehaviour
{
    // Start is called before the first frame update
    public int StartLevelSceneNumber = 1;

    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene(StartLevelSceneNumber);
    }

    public void OnExitButtonClicked()
    {
#if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }
}
