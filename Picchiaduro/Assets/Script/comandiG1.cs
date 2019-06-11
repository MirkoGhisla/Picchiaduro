using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comandiG1 : MonoBehaviour
{

    Animator anim;
    int pugno = Animator.StringToHash("pugno");
    int calcio = Animator.StringToHash("calcio");
    int salto = Animator.StringToHash("salto");
   
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
            if (Input.GetKey(KeyCode.D))
            {
                anim.SetBool("corre", true);
                transform.Translate(0, 0, +0.7f);

            }
            else if (Input.GetKeyUp(KeyCode.D))
                anim.SetBool("corre", false);

            if (Input.GetKey(KeyCode.A))
            {
                anim.SetBool("corre", true);
                transform.Translate(0, 0, -0.7f);

            }
            else if (Input.GetKeyUp(KeyCode.A))
                anim.SetBool("corre", false);



            if (Input.GetKeyDown(KeyCode.V))
            {
                anim.SetTrigger(pugno);
                GetComponent<SphereCollider>().enabled = true;
                StartCoroutine(aspetta());
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                anim.SetTrigger(calcio);
                GetComponent<SphereCollider>().enabled = true;
                StartCoroutine(aspetta());
            }
            if (Input.GetKeyDown(KeyCode.W))
                anim.SetTrigger(salto);
        }
    }

    IEnumerator aspetta()
    {
        yield return new WaitForSeconds(2.0f);
        GetComponent<SphereCollider>().enabled = false;
    }
}
