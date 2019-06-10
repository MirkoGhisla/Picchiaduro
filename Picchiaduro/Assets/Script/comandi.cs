using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comandi : MonoBehaviour
{

    Animator anim;
    int pugno = Animator.StringToHash("pugno");
    int calcio = Animator.StringToHash("calcio");
    int salto = Animator.StringToHash("salto");

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
                transform.Translate(0, 0, +0.7f);
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, -0.7f);
        }

        if (Input.GetKeyDown(KeyCode.V))
            anim.SetTrigger(pugno);

        if (Input.GetKeyDown(KeyCode.X))
            anim.SetTrigger(calcio);

        if (Input.GetKeyDown(KeyCode.W))
            anim.SetTrigger(salto);

    }



}
