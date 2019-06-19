using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterFight : MonoBehaviour
{

    public void Rematch()
    {
        SceneManager.LoadScene("Game");
    }

    public void CharacterSel()
    {
        //TO DO
    }

    public void StageSel()
    {
        //TO DO
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
