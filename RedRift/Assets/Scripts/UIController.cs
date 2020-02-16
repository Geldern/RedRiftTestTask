using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public Text ScoreText;
    public ScoreData Score;

    private void Update()
    {
        ScoreText.text = "BallHits: " + Score.CurrentScore;
    }

    public void LoadEarth()
    {
        SceneManager.LoadScene("Earth");
    }

    public void LoadMoon()
    {
        SceneManager.LoadScene("Moon");
    }

    public void LoadJupiter()
    {
        SceneManager.LoadScene("Jupiter");
    }
}
