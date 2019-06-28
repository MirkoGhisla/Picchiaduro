using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
            SceneManager.UnloadSceneAsync("Pausa");
    }
    public void Resume()
    {
        SceneManager.UnloadSceneAsync("Pausa");
    }

    public void Rematch()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CharacterSel()
    {
        SceneManager.LoadScene("CharacterSel");
        CharSelManager.TuttoFalzo();
    }

    public void StageSel()
    {
        SceneManager.LoadScene("StageSel");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
