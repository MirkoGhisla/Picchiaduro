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


        
        }

    }
}
