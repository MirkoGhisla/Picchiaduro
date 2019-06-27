using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsMenu : MonoBehaviour
{
    public GameObject g1Keyb1, g1Keyb2, g1Keyb3; //g1Joys1,g1Joys2
    public GameObject g2Keyb1, g2Keyb2, g2Keyb3; //g2Joys1,g2Joys2



    void Start()
    {
        if (ControlsManager.g1Keyb1)
        {
            g1Keyb1.SetActive(true);
            g1Keyb2.SetActive(false);
            g1Keyb3.SetActive(false);
            //g1Joys1.SetActive(false);
            //g1Joys2.SetActive(false);
        }
        else if (ControlsManager.g1Keyb2)
        {
            g1Keyb1.SetActive(false);
            g1Keyb2.SetActive(true);
            g1Keyb3.SetActive(false);
            //g1Joys1.SetActive(false);
            //g1Joys2.SetActive(false);
        }
        else if (ControlsManager.g1Keyb3)
        {
            g1Keyb1.SetActive(false);
            g1Keyb2.SetActive(false);
            g1Keyb3.SetActive(true);
            //g1Joys1.SetActive(false);
            //g1Joys2.SetActive(false);
        }

        //else if (ControlsManager.g1Joys1)
        //{
        //    g1Keyb1.SetActive(false);
        //    g1Keyb2.SetActive(false);
        //g1Keyb3.SetActive(false);
        //g1Joys1.SetActive(true);
        //g1Joys2.SetActive(false);
        //}
        //else if (ControlsManager.g1Joys2)
        //{
        //    g1Keyb1.SetActive(false);
        //    g1Keyb2.SetActive(false);
        //g1Keyb3.SetActive(false);
        //g1Joys1.SetActive(false);
        //g1Joys2.SetActive(true);
        //}



        if (ControlsManager.g2Keyb1)
        {
            g2Keyb1.SetActive(true);
            g2Keyb2.SetActive(false);
            g2Keyb3.SetActive(false);
            //g2Joys1.SetActive(false);
            //g2Joys2.SetActive(false);
        }
        else if (ControlsManager.g2Keyb2)
        {
            g2Keyb1.SetActive(false);
            g2Keyb2.SetActive(true);
            g2Keyb3.SetActive(false);
            //g2Joys1.SetActive(false);
            //g2Joys2.SetActive(false);
        }
        else if (ControlsManager.g2Keyb3)
        {
            g2Keyb1.SetActive(false);
            g2Keyb2.SetActive(false);
            g2Keyb3.SetActive(true);
            //g2Joys1.SetActive(false);
            //g2Joys2.SetActive(false);
        }
        //else if (ControlsManager.g2Joys1)
        //{
        //    g2Keyb1.SetActive(false);
        //    g2Keyb2.SetActive(false);
        //    g2Keyb3.SetActive(false);
        //    g2Joys1.SetActive(true);
        //    g2Joys2.SetActive(false);
        //}
        //else if (ControlsManager.g2Joys2)
        //{
        //    g2Keyb1.SetActive(false);
        //    g2Keyb2.SetActive(false);
        //    g2Keyb3.SetActive(false);
        //    g2Joys1.SetActive(false);
        //    g2Joys2.SetActive(true);
        //}
    }
    public void ChangeControlsNextG1()
    {
        switch (ControlsManager.controlsG1)
        {
            case 1:
                g1Keyb1.SetActive(false);
                g1Keyb2.SetActive(true);
                ControlsManager.controlsG1++;
                break;
            case 2:
                g1Keyb2.SetActive(false);
                g1Keyb3.SetActive(true);
                ControlsManager.controlsG1++;
                break;
            case 3:
                g1Keyb3.SetActive(false);
                g1Keyb1.SetActive(true); //g1Joys1.SetActive(true);
                ControlsManager.controlsG1 = 1; //ControlsManager.controlsG1++;
                break;
                //case 4:
                //    g1Joys1.SetActive(false);
                //    g1Joys2.SetActive(true);
                //    ControlsManager.controlsG1++;
                //    break;
                //case 5:
                //    g1Joys2.SetActive(false);
                //    g1Keyb1.SetActive(true);
                //    ControlsManager.controlsG1 = 1;
                //    break;
        }
    }

    public void ChangeControlsNextG2()
    {
        switch (ControlsManager.controlsG2)
        {
            case 1:
                g2Keyb1.SetActive(false);
                g2Keyb2.SetActive(true);
                ControlsManager.controlsG2++;
                break;
            case 2:
                g2Keyb2.SetActive(false);
                g2Keyb3.SetActive(true); 
                ControlsManager.controlsG2++;
                break;
            case 3:
                g2Keyb3.SetActive(false);
                g2Keyb1.SetActive(true); //g2Joys1.SetActive(true);
                ControlsManager.controlsG2 = 1; //ControlsManager.controlsG2++;
                break;
                //case 4:
                //    g2Joys1.SetActive(false);
                //    g2Joys2.SetActive(true);
                //    ControlsManager.controlsG2++;
                //    break;
                //case 5:
                //    g2Joys2.SetActive(false);
                //    g2Keyb1.SetActive(true);
                //    ControlsManager.controlsG2 = 1;
                //    break;
        }
    }
    public void ConfirmSettings()
    {
        if (g1Keyb1.activeSelf == true)
            ControlsManager.G1keyboard1();
        else if (g1Keyb2.activeSelf == true)
            ControlsManager.G1keyboard2();
        else if (g1Keyb3.activeSelf == true)
            ControlsManager.G1keyboard3();
        //else if (g1Joys1.activeSelf == true)
        //    ControlsManager.G1joystick1();
        //else if (g1Joys2.activeSelf == true)
        //    ControlsManager.G1joystick2();

        if (g2Keyb1.activeSelf == true)
            ControlsManager.G2keyboard1();
        else if (g2Keyb2.activeSelf == true)
            ControlsManager.G2keyboard2();
        else if (g2Keyb3.activeSelf == true)
            ControlsManager.G2keyboard3();
        //else if (g2Joys1.activeSelf == true)
        //    ControlsManager.G2joystick1();
        //else if (g2Joys2.activeSelf == true)
        //    ControlsManager.G2joystick2();

        SceneManager.LoadScene("Options");
    }
    public void BackToOptions()
    {
        SceneManager.LoadScene("Options");
    }
}
