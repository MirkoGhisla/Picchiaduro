using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsManager : MonoBehaviour
{
    public static bool g1Keyb1, g1Keyb2, g1Joys1, g1Joys2;
    public static bool g2Keyb1, g2Keyb2, g2Joys1, g2Joys2;

    public static int controlsG1;
    public static int controlsG2;
    private void Awake()
    {
        g1Keyb1 = true;
        g1Keyb2 = false;
        g1Joys1 = false;
        g1Joys2 = false;
        controlsG1 = 1;


        g2Keyb1 = false;
        g2Keyb2 = true;
        g2Joys1 = false;
        g2Joys2 = false;
        controlsG2 = 2;
    }
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public static void G1keyboard1()
    {
        g1Keyb1 = true;
        g1Keyb2 = false;
        g1Joys1 = false;
        g1Joys2 = false;
        controlsG1 = 1;
    }
    public static void G1keyboard2()
    {
        g1Keyb1 = false;
        g1Keyb2 = true;
        g1Joys1 = false;
        g1Joys2 = false;
        controlsG1 = 2;
    }
    public static void G1joystick1()
    {
        g1Keyb1 = false;
        g1Keyb2 = false;
        g1Joys1 = true;
        g1Joys2 = false;
        controlsG1 = 3;
    }

    public static void G1joystick2()
    {
        g1Keyb1 = false;
        g1Keyb2 = false;
        g1Joys1 = false;
        g1Joys2 = true;
        controlsG1 = 4;
    }



    public static void G2keyboard1()
    {
        g2Keyb1 = true;
        g2Keyb2 = false;
        g2Joys1 = false;
        g2Joys2 = false;
        controlsG2 = 1;
    }
    public static void G2keyboard2()
    {
        g2Keyb1 = false;
        g2Keyb2 = true;
        g2Joys1 = false;
        g2Joys2 = false;
        controlsG2 = 2;
    }
    public static void G2joystick1()
    {
        g2Keyb1 = false;
        g2Keyb2 = false;
        g2Joys1 = true;
        g2Joys2 = false;
        controlsG2 = 3;
    }

    public static void G2joystick2()
    {
        g2Keyb1 = false;
        g2Keyb2 = false;
        g2Joys1 = false;
        g2Joys2 = true;
        controlsG2 = 4;
    }
}
