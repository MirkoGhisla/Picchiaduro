using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharcaterSel : MonoBehaviour
{
    private bool g1HasSelected = false;
    private bool g2HasSelected = false;

    public GameObject title1, title2;




    public void SelectCharacter(string characterName)
    {
        if (!g1HasSelected)
            G1Select(characterName);
        else if (!g2HasSelected)
            G2Select(characterName);
    }
    void G1Select(string characterName)
    {
        switch (characterName)
        {
            case "Ghost":
                CharSelManager.GhostG1 = true;
                g1HasSelected = true;
                title1.SetActive(false);
                title2.SetActive(true);
                break;
            case "BlackWhite":
                CharSelManager.BlackWhiteG1 = true;
                g1HasSelected = true;
                title1.SetActive(false);
                title2.SetActive(true);
                break;

        }
    }

    void G2Select(string characterName)
    {
        switch (characterName)
        {
            case "Ghost":
                CharSelManager.GhostG2 = true;
                g2HasSelected = true;
                SceneManager.LoadScene("StageSel");
                break;
            case "BlackWhite":
                CharSelManager.BlackWhiteG2 = true;
                g2HasSelected = true;
                SceneManager.LoadScene("StageSel");
                break;

        }
    }
}
