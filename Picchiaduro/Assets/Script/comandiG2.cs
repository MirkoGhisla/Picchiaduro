using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comandiG2 : MonoBehaviour
{
    private static Animator anim;

    int pugno = Animator.StringToHash("pugno");
    int calcio = Animator.StringToHash("calcio");
    int salto = Animator.StringToHash("salto");
    int calcioPesante = Animator.StringToHash("calcioPesante");
    //int vieneColpito = Animator.StringToHash("vieneColpito");

    public float altezzaSalto, velCorsa, velParata;         //vel parata corrisponde alla velocità di movimento all'indietro

    public GameObject target;

    bool stoColpendo = false;
    public static bool colpito = false;
    bool isGrounded = true;

    public static int danno = 0;

    void Start()
    {
        GetComponent<Rigidbody>().freezeRotation = true;
        anim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("G1");
        altezzaSalto = 40;
        velCorsa = 3;
        velParata = 1.8f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < target.transform.position.x - 10)
        {
            GetComponent<Rigidbody>().freezeRotation = false;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, 90, transform.eulerAngles.z);
            GetComponent<Rigidbody>().freezeRotation = true;
        }
        else
        {
            GetComponent<Rigidbody>().freezeRotation = false;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, 270, transform.eulerAngles.z);
            GetComponent<Rigidbody>().freezeRotation = true;
        }

        if (!anim.GetBool("vinci") && !anim.GetBool("perdi"))
        {

            if (Input.GetKey(KeyCode.LeftArrow) && !stoColpendo)
            {
                if (transform.eulerAngles.y.Equals(270f))
                {
                    anim.SetBool("corre", true);
                    transform.Translate(0, 0, +velCorsa);
                }
                else
                {
                    anim.SetBool("parata", true);
                    transform.Translate(0, 0, -velParata);
                }

            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow))
            {

                    anim.SetBool("corre", false);
                    anim.SetBool("parata", false);
            }

            if (Input.GetKey(KeyCode.RightArrow) && !stoColpendo)
            {
                if (transform.eulerAngles.y.Equals(270f))
                {
                    anim.SetBool("parata", true);
                    transform.Translate(0, 0, -velParata);
                }
                else
                {
                    anim.SetBool("corre", true);
                    transform.Translate(0, 0, +velCorsa);
                }

            }
            else if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                    anim.SetBool("parata", false);
                    anim.SetBool("corre", false);
            }


            if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
            {
                isGrounded = false;
                JumpManagement();
            }


            if (!colpito)
            {
                
                if (Input.GetKeyDown(KeyCode.L) && !stoColpendo)
                {
                    danno = 100;
                    anim.SetTrigger(pugno);
                    stoColpendo = true;
                }
                if (Input.GetKeyDown(KeyCode.K) && !stoColpendo)
                {
                    danno = 100;
                    anim.SetTrigger(calcio);
                    stoColpendo = true;
                }
                if (Input.GetKeyDown(KeyCode.O))
                {
                    danno = 200;
                    anim.SetTrigger(calcioPesante);
                    stoColpendo = true;
                }
            }
            //else if (colpito)
            //{
            //    anim.SetTrigger(vieneColpito);
            //}
        }

        if (transform.position.y <= 2.8050)
        {
            isGrounded = true;
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

    public static void vieneColpito()
    {
        anim.SetTrigger("vieneColpito");
    }

    void JumpManagement()
    {

        Rigidbody rigidBody = GetComponent<Rigidbody>();
        // Start a new jump.

        // Set jump related parameters.
        //behaviourManager.LockTempBehaviour(this.behaviourCode);
        //behaviourManager.GetAnim.SetBool(salto, true);
        // Is a locomotion jump?
        //if (behaviourManager.GetAnim.GetFloat(speedFloat) > 0.1)
        //{
        // Temporarily change player friction to pass through obstacles.
        anim.SetTrigger(salto);
        GetComponent<BoxCollider>().material.dynamicFriction = 0f;
        GetComponent<BoxCollider>().material.staticFriction = 0f;
        // Remove vertical velocity to avoid "super jumps" on slope ends.
        //RemoveVedrticalVelocity();
        Vector3 horizontalVelocity = rigidBody.velocity;
        horizontalVelocity.y = 0;
        rigidBody.velocity = horizontalVelocity;
        // Set jump vertical impulse velocity.
        float velocity = 4f * Mathf.Abs(Physics.gravity.y) * altezzaSalto;
        velocity = Mathf.Sqrt(velocity);
        rigidBody.AddForce(Vector3.up * velocity, ForceMode.VelocityChange);
        //}

        // Is already jumping?
        //if (anim.GetBool("salto"))
        //{
        // Keep forward movement while in the air.
        //if (!behaviourManager.IsGrounded() && !isColliding && behaviourManager.GetTempLockStatus())
        //{
        //    behaviourManager.GetRigidBody.AddForce(transform.forward * jumpIntertialForce * Physics.gravity.magnitude * sprintSpeed, ForceMode.Acceleration);
        //}
        // Has landed?
            if (rigidBody.velocity.y <= 0)
            {
                //behaviourManager.GetAnim.SetBool(groundedBool, true);
                // Change back player friction to default.
                GetComponent<BoxCollider>().material.dynamicFriction = 0.6f;
                GetComponent<BoxCollider>().material.staticFriction = 0.6f;
                // Set jump related parameters.
                //jump = false;
                //behaviourManager.UnlockTempBehaviour(this.behaviourCode);
            }
        //}
    }

    //private void RemoveVerticalVelocity(Rigidbody rigidBody)
    //{
    //    Vector3 horizontalVelocity = behaviourManager.GetRigidBody.velocity;
    //        horizontalVelocity.y = 0;
    //  behaviourManager.GetRigidBody.velocity = horizontalVelocity;
    //}
}


