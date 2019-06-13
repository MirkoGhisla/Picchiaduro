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
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                anim.SetBool("corre", true);
                transform.Translate(0, 0, +0.9f);

            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow))
                anim.SetBool("corre", false);

            if (Input.GetKey(KeyCode.RightArrow))
            {
                anim.SetBool("corre", true);
                transform.Translate(0, 0, -0.9f);

            }
            else if (Input.GetKeyUp(KeyCode.RightArrow))
                anim.SetBool("corre", false);

            if (Input.GetKeyDown(KeyCode.L))
            {
                anim.SetTrigger(pugno);
                GetComponent<SphereCollider>().enabled = true;
                StartCoroutine(aspetta());
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                anim.SetTrigger(calcio);
                GetComponent<SphereCollider>().enabled = true;
                StartCoroutine(aspetta());
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
                anim.SetTrigger(salto);
        }

    }

    IEnumerator aspetta()
    {
        yield return new WaitForSeconds(2.0f);
        GetComponent<SphereCollider>().enabled = false;
    }

}
