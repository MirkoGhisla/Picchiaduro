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
                vite.G1currentHealth -= 100;
            }

            if (tag == "G2")
            {
                vite.G2currentHealth -= 100;
            }

        }

    }
}
