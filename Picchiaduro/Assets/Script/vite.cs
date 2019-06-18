using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class vite : MonoBehaviour
{
    public int startingHealth = 1000;
    public static int G1currentHealth, G2currentHealth;
    public Slider G1healthSlider;
    public Slider G2healthSlider;

    Animator animG1, animG2;

    public GameObject g1, g2;
    public GameObject g1win, g2win;

    void Start()
    {
        animG1 = g1.GetComponent<Animator>();
        animG2 = g2.GetComponent<Animator>();

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
            animG1.SetBool("perdi", true);
            animG2.SetBool("vinci", true);
            g2win.SetActive(true);
            StartCoroutine(BackToTheMenu());
        }

        else if (G2currentHealth <= 0)
        {
            Debug.Log("G2 Perdeh");
            animG2.SetBool("perdi", true);
            animG1.SetBool("vinci", true);
            g1win.SetActive(true);
            StartCoroutine(BackToTheMenu());
        }
    }

    IEnumerator BackToTheMenu()
    {
        yield return new WaitForSeconds(4.0f);
        SceneManager.LoadScene("Menu");
    }
}
