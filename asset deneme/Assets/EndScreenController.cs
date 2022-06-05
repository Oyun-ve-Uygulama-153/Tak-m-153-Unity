using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenController : MonoBehaviour
{
    // Start is called before the first frame update
    public int StartLevelSceneNumber = 1;

    public GameObject MainCharacter;
    public TMPro.TextMeshProUGUI ScoreResult;
    public TMPro.TextMeshProUGUI HealthResult;

    private void FixedUpdate()
    {
        ScoreResult.text = "Score: " + MainCharacter.GetComponent<CoinCounter>().GetScore();
        HealthResult.text = "Health: " + MainCharacter.GetComponent<HealthCounter>().GetHealth();
    }

    public void OnPlayAgainButtonClicked()
    {
        SceneManager.LoadScene(StartLevelSceneNumber);
        MainCharacter.GetComponent<CoinCounter>().ResetScore();
        MainCharacter.GetComponent<HealthCounter>().ResetHealth();
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
