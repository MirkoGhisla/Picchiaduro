﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelManager : MonoBehaviour
{
    public static bool GhostG1, BlackWhiteG1;
    public static bool GhostG2, BlackWhiteG2;

    private void Awake()
    {
        GhostG1 = false;
        BlackWhiteG1 = false;

        GhostG2 = false;
        BlackWhiteG2 = false;
    }
    void Start()
    {
        DontDestroyOnLoad(this);
    }

}