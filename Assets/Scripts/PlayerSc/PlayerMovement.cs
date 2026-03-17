using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpSpeed;
    private float moveInput;
    int jumpAmount;
   



    Animator anim;
    Rigidbody2D rb;
    void Start()
    {
        jumpAmount = 2;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
       CheckMoveInput();
        
    }
    private void FixedUpdate()
    {
        Run();
        if(GroundCheck.isGrounded == false)
        {
            anim.SetBool("Jump", true);
            anim.SetBool("Run", false);

        }
        if (GroundCheck.isGrounded == true)
        {
            anim.SetBool("Jump", false);
            

        }
    }

    public void Run()
    {

            rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
            

    }
    public void CheckMoveInput()
    {
        moveInput = CrossPlatformInputManager.GetAxis("Horizontal");
        anim.SetBool("Run", moveInput != 0);

        if (moveInput > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (moveInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (CrossPlatformInputManager.GetButtonDown("Jump") && jumpAmount >0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x,jumpSpeed);
            jumpAmount--;
            
        }
        if (jumpAmount <= 0 && GroundCheck.isGrounded == true)
        {
            jumpAmount = 2;
        }


    }
   
}
