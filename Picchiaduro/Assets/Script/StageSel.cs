﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSel : MonoBehaviour
{
    

    public void LoadStage(string StageName)
    {
        
        switch (StageName)
        {
            case "Fuji":
                SceneManager.LoadScene("Fuji");
                break;
            case "Forest":
                SceneManager.LoadScene("Forest");
                break;
        }
    }

    public void GoBack()
    {
        SceneManager.LoadScene("CharacterSel");
    }
}
