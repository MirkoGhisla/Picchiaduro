using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comandiG1 : MonoBehaviour
{

    Animator anim;

    int pugno = Animator.StringToHash("pugno");
    int calcio = Animator.StringToHash("calcio");
    int salto = Animator.StringToHash("salto");

    public float altezzaSalto;

    public GameObject target;

    bool stoColpendo = false;
    public static bool colpito = false;
    bool isGrounded = true;

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
            if (!stoColpendo)
            {
                if (Input.GetKey(KeyCode.D))
                {
                    anim.SetBool("corre", true);
                    transform.Translate(0, 0, +1.3f);

                }
                else if (Input.GetKeyUp(KeyCode.D))
                    anim.SetBool("corre", false);

                if (Input.GetKey(KeyCode.A))
                {
                    anim.SetBool("parata", true);
                    transform.Translate(0, 0, -0.8f);

                }
                else if (Input.GetKeyUp(KeyCode.A))
                    anim.SetBool("parata", false);

                if (Input.GetKeyDown(KeyCode.W) && isGrounded)
                {
                    isGrounded = false;
                    JumpManagement();
                }

            }

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


        }

        if(transform.position.y<= 2.8050)
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
        anim.SetBool("salto", true);
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
        if (rigidBody.velocity.y < 0)
        {
            //behaviourManager.GetAnim.SetBool(groundedBool, true);
            // Change back player friction to default.
            GetComponent<CapsuleCollider>().material.dynamicFriction = 0.6f;
            GetComponent<CapsuleCollider>().material.staticFriction = 0.6f;
            // Set jump related parameters.
            //jump = false;
            anim.SetBool(salto, false);

            //behaviourManager.UnlockTempBehaviour(this.behaviourCode);
        }
        //}
    }
}
