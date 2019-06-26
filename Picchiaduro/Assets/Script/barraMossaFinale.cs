using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class stamina : MonoBehaviour
{
    public int Stamina = 0;
    public static int G1currentStamina, G2currentStamina;
    public static bool MossaFinaleG1, MossaFinaleG2;     //booleane per capire se possono fare la loro mossa finale
    //public Slider G1StaminaSlider;
    //public Slider G2StaminaSlider;

    Animator animG1, animG2;

    GameObject g1, g2;

    // Start is called before the first frame update
    void Start()
    {
        g1 = GameObject.FindGameObjectWithTag("G1");
        g2 = GameObject.FindGameObjectWithTag("G2");

        animG1 = g1.GetComponent<Animator>();
        animG2 = g2.GetComponent<Animator>();

        G1currentStamina = Stamina;
        G2currentStamina = Stamina;
    }
    
    void Update()
    {
        //G1StaminaSlider.value = G1currentStamina;
        //G2StaminaSlider.value = G2currentStamina;

        if (G1currentStamina >= 700)
        {
            MossaFinaleG1 = true;
        }
        else if (G2currentStamina >= 700)
        {
            MossaFinaleG2 = true;
        }
    }
}
