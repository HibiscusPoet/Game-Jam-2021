using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ViewCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
