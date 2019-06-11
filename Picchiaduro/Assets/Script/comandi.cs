using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comandi : MonoBehaviour
{

    Animator anim;
    int pugno = Animator.StringToHash("pugno");
    int calcio = Animator.StringToHash("calcio");
    int salto = Animator.StringToHash("salto");
    int corre = Animator.StringToHash("corre");

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {

            anim.SetBool("corre", true);
            transform.Translate(new Vector3(+0.7f, 0, 0), Space.World);
        } else if(Input.GetKeyUp(KeyCode.D))
            anim.SetBool("corre", false);

        if (Input.GetKey(KeyCode.A))
        {

            anim.SetBool("corre", true);
            transform.Translate(new Vector3(-0.7f, 0, 0), Space.World);            
        }else if (Input.GetKeyUp(KeyCode.A))
            anim.SetBool("corre", false);


        if (Input.GetKeyDown(KeyCode.V))
            anim.SetTrigger(pugno);

        if (Input.GetKeyDown(KeyCode.X))
            anim.SetTrigger(calcio);

        if (Input.GetKeyDown(KeyCode.W))
            anim.SetTrigger(salto);

    }
}
