using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsMenu : MonoBehaviour
{
    public void ChangeControls()
    {

    }
    public void ConfirmSettings()
    {
        SceneManager.LoadScene("Options");
    }
    public void BackToOptions()
    {
        SceneManager.LoadScene("Options");
    }
}
