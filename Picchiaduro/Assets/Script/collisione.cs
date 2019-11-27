using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisione : MonoBehaviour
{
    GameObject g1, g2;
    public LayerMask collisionLayer;
    public float radius = 1f;


    void Start()
    {
        g1 = GameObject.FindGameObjectWithTag("G1");
        g2 = GameObject.FindGameObjectWithTag("G2");
    }

    void Update()
    {
        DetectCollision();
    }

    void DetectCollision()
    {
        
        Collider[] hit = Physics.OverlapSphere(transform.position, radius, collisionLayer);
        if (hit.Length > 0)
            
        {
            print(collisionLayer.value);
            if (collisionLayer.value==256)
            {
                //if (GetComponent<Animator>().GetBool("parata"))
                //    return;
                //else
                //{
                    comandiG2.PlaySound(comandiG2.suono);
                    comandiG1.colpito = true;
                    vite.G1currentHealth -= comandiG2.danno;
                    stamina.G1currentStamina += 100;
                    stamina.G2currentStamina += 50;
                    StartCoroutine(G1nonColpito());
                //}
            }
            int a = collisionLayer.value;
            
            if (a==512)
            {
               // if (GetComponent<Animator>().GetBool("parata"))
                 ///   return;
               // else
                //{
                    //g1.GetComponent<SphereCollider>().enabled = false;
                    comandiG2.colpito = true;
                    comandiG1.PlaySound(comandiG1.suono);
                    vite.G2currentHealth -= comandiG1.danno;
                    stamina.G2currentStamina += 100;
                    stamina.G1currentStamina += 50;
                    StartCoroutine(G2nonColpito());
               // }
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