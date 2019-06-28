using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inizioh : MonoBehaviour
{

    public GameObject scritta, logo;

    public void LogoComparisci()
    {
        scritta.SetActive(false);
        logo.SetActive(true);
    }
    public void VaiAlMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
