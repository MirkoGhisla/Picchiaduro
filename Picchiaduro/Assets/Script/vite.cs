using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class vite : MonoBehaviour
{
    public int startingHealth = 1000;
    public static int G1currentHealth, G2currentHealth;
    public Slider G1healthSlider, G2healthSlider;

    void Start()
    {
        G1currentHealth = startingHealth;
        G2currentHealth = startingHealth;
    }

    
    void Update()
    {
        G1healthSlider.value = G1currentHealth;
        G2healthSlider.value = G2currentHealth;
    }
}
