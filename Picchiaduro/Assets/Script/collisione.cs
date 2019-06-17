using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisione : MonoBehaviour
{
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
                    comandiG1.colpito = true;
                    vite.G1currentHealth -= 100;
                    StartCoroutine(G1nonColpito());
                }
            }

            if (tag == "G2")
            {
                if (GetComponent<Animator>().GetBool("parata"))
                    vite.G2currentHealth = vite.G2currentHealth;
                else
                {
                    comandiG2.colpito = true;
                    vite.G2currentHealth -= 100;
                    StartCoroutine(G2nonColpito());
                }
            }

        }

    }

    IEnumerator G1nonColpito()
    {
        yield return new WaitForSeconds(0.5f);
        comandiG1.colpito = false;
    }

    IEnumerator G2nonColpito()
    {
        yield return new WaitForSeconds(0.5f);
        comandiG2.colpito = false;
    }
}