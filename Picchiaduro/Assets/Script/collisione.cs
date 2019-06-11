using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisione : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.GetType().ToString() == "UnityEngine.SphereCollider")
        {
            Debug.Log("AIUTO SONO MORTO");
        }

    }
}
