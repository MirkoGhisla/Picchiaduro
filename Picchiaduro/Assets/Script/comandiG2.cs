using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comandiG2 : MonoBehaviour
{
    Animator anim;
    int pugno = Animator.StringToHash("pugno");
    int calcio = Animator.StringToHash("calcio");
    int salto = Animator.StringToHash("salto");
    public GameObject target;

    bool stoColpendo = false;
    public static bool colpito = false;

    void Start()
    {
        GetComponent<Rigidbody>().freezeRotation = true;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        if (!anim.GetBool("vinci") && !anim.GetBool("perdi"))
        {
            if (Input.GetKey(KeyCode.LeftArrow) && !stoColpendo)
            {
                anim.SetBool("corre", true);
                transform.Translate(0, 0, +1.3f);

            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow))
                anim.SetBool("corre", false);

            if (Input.GetKey(KeyCode.RightArrow) && !stoColpendo)
            {
                anim.SetBool("corre", true);
                transform.Translate(0, 0, -0.9f);

            }
            else if (Input.GetKeyUp(KeyCode.RightArrow))
                anim.SetBool("corre", false);

            if (!colpito)
            {
                if (Input.GetKeyDown(KeyCode.L) && !stoColpendo)
                {
                    anim.SetTrigger(pugno);
                    GetComponent<SphereCollider>().enabled = true;
                    stoColpendo = true;
                }

                if (Input.GetKeyDown(KeyCode.K) && !stoColpendo)
                {
                    anim.SetTrigger(calcio);
                    GetComponent<SphereCollider>().enabled = true;
                    stoColpendo = true;
                }
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
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
