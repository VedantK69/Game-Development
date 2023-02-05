using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 

    public float sprintModifier;
    public Animator anim;
    private Rigidbody rb;
    public LayerMask layerMask;
    public bool grounded;
    public float Jumpforce;
    public Camera normalCam;
    public float speed = 12f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;

    Vector3 velocity;
    

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Grounded();
        Jump();
        Move();       
    }
   
    private void Jump()
    {
       
        if (Input.GetKey(KeyCode.Space) && GetComponent<Rigidbody>().velocity.y == 0)
        /*if(Input.GetKeyDown(KeyCode.Space) &&tis.grounded)*/
        {
            
          this.rb.AddForce(Vector3.up * 4, ForceMode.Impulse);
          this.rb.AddForce(new Vector3(0, Jumpforce), ForceMode.Impulse);
        }
    }

    private void Grounded()
    {
        if(Physics.CheckSphere(this.transform.position + Vector3.down, 0.2f, layerMask))
    {
        this.grounded = true;
    }
  else
  {
   this.grounded = false;
  }

   this.anim.SetBool("Jump", !this.grounded);
 }

 private void Move()
 {
   float verticalAxis = Input.GetAxis("Vertical");
   float horizontalAxis = Input.GetAxis("Horizontal");

   Vector3 movement = this.transform.forward * verticalAxis + this.transform.right * horizontalAxis;
   movement.Normalize();

   this.transform.position += movement * 0.04f;

   this.anim.SetFloat("Vertical", verticalAxis);
   this.anim.SetFloat("Horizontal", horizontalAxis);

        velocity.y += gravity * Time.deltaTime;

       
 }
   
}

    

