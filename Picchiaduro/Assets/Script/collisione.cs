using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisione : MonoBehaviour
{

    public int startingHealth = 1000;                            
    public int currentHealth;                                   
    public Slider healthSlider;

    private void Start()
    {
        currentHealth = startingHealth;
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.GetType().ToString() == "UnityEngine.SphereCollider")
        {

  
            currentHealth -= 100;


            healthSlider.value = currentHealth;

        
        }

    }
}
