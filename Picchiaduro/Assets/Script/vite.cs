using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vite : MonoBehaviour
{
    public int startingHealth = 1000;
    public static int G1currentHealth, G2currentHealth;
    public Slider G1healthSlider;
    public Slider G2healthSlider;

    public GameObject g1, g2;

    void Start()
    {
        G1currentHealth = startingHealth;
        G2currentHealth = startingHealth;
    }

    
    void Update()
    {
        G1healthSlider.value = G1currentHealth;
        G2healthSlider.value = G2currentHealth;

        if (G1currentHealth <= 0)
        {
            Debug.Log("G1 Perdeh");
            Application.Quit();
        }

        else if (G2currentHealth <= 0)
        {
            Debug.Log("G2 Perdeh");
        }
    }
}
