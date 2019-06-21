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
                    vite.G1currentHealth = vite.G1currentHealth;
                else
                {
                    //g2.GetComponent<SphereCollider>().enabled = false;
                    comandiG1.colpito = true;
                    vite.G1currentHealth -= comandiG2.danno;
                    StartCoroutine(G1nonColpito());
                }
            }

            if (tag == "G2")
            {
                if (GetComponent<Animator>().GetBool("parata"))
                    vite.G2currentHealth = vite.G2currentHealth;
                else
                {
                    //g1.GetComponent<SphereCollider>().enabled = false;
                    comandiG2.colpito = true;
                    vite.G2currentHealth -= comandiG1.danno;
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