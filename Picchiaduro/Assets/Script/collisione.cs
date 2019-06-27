using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisione : MonoBehaviour
{
    GameObject g1, g2;

    void Start()
    {
        g1 = GameObject.FindGameObjectWithTag("G1");
        g2 = GameObject.FindGameObjectWithTag("G2");
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.GetType().ToString() == "UnityEngine.SphereCollider")
        {
            if (tag == "G1")
            {
                if (GetComponent<Animator>().GetBool("parata"))
                    return;
                else
                {
                    comandiG2.PlaySound(comandiG2.suono);
                    comandiG1.colpito = true;
                    vite.G1currentHealth -= comandiG2.danno;
                    stamina.G1currentStamina += 100;
                    stamina.G2currentStamina += 50;
                    StartCoroutine(G1nonColpito());
                }
            }

            if (tag == "G2")
            {
                if (GetComponent<Animator>().GetBool("parata"))
                    return;
                else
                {
                    //g1.GetComponent<SphereCollider>().enabled = false;
                    comandiG2.colpito = true;
                    comandiG1.PlaySound(comandiG1.suono);
                    vite.G2currentHealth -= comandiG1.danno;
                    stamina.G2currentStamina += 100;
                    stamina.G1currentStamina += 50;
                    StartCoroutine(G2nonColpito());
                }
            }

        }

    }

    IEnumerator G1nonColpito()
    {
        comandiG1.vieneColpito();
        yield return new WaitForSeconds(0.5f);
        comandiG1.colpito = false;
    }

    IEnumerator G2nonColpito()
    {
        comandiG2.vieneColpito();
        yield return new WaitForSeconds(0.5f);
        comandiG2.colpito = false;
    }
}