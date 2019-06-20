using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterFight : MonoBehaviour
{

    public void Rematch()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CharacterSel()
    {
        SceneManager.LoadScene("CharacterSel");
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
