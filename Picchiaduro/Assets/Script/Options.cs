using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public void GameSettings()
    {
        SceneManager.LoadScene("GameSettings");
    }
    public void ControlsSettings()
    {
        SceneManager.LoadScene("Controls");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
