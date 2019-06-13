using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comandiG1 : MonoBehaviour
{

    Animator anim;
    int pugno = Animator.StringToHash("pugno");
    int calcio = Animator.StringToHash("calcio");
    int salto = Animator.StringToHash("salto");
    public GameObject target;

    public bool stoColpendo = false;
    public static bool colpito = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        GetComponent<Rigidbody>().freezeRotation = true;
    }
    
    // Update is called once per frame
    void Update()
    {
       

        if (!anim.GetBool("vinci") && !anim.GetBool("perdi"))
        {

            if (Input.GetKey(KeyCode.D) && !stoColpendo)
            {
                anim.SetBool("corre", true);
                transform.Translate(0, 0, +1.3f);

            }
            else if (Input.GetKeyUp(KeyCode.D))
                anim.SetBool("corre", false);

            if (Input.GetKey(KeyCode.A) && !stoColpendo)
            {
                anim.SetBool("corre", true);
                transform.Translate(0, 0, -0.9f);

            }
            else if (Input.GetKeyUp(KeyCode.A))
                anim.SetBool("corre", false);


            if (!colpito)
            {
                if (Input.GetKeyDown(KeyCode.V) && !stoColpendo)
                {
                    anim.SetTrigger(pugno);
                    GetComponent<SphereCollider>().enabled = true;
                    stoColpendo = true;
                }
                if (Input.GetKeyDown(KeyCode.C) && !stoColpendo)
                {
                    anim.SetTrigger(calcio);
                    GetComponent<SphereCollider>().enabled = true;
                    stoColpendo = true;
                }
            }
            if (Input.GetKeyDown(KeyCode.W))
                anim.SetTrigger(salto);
        }
    }

    public void aspetta()
    {
        GetComponent<SphereCollider>().enabled = false;
    }

    public void fineColpo()
    {
        stoColpendo = false;
    }
}
