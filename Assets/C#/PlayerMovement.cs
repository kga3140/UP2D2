using StarterAssets;
using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    public bool isGrounded;
    public ControlVariant control = ControlVariant.PC;
    public StarterAssetsInputs input;
    public Animator anim;
    public bool isMove=false;

    public enum ControlVariant
    {
        MOBILE,
        PC
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnCollisionStay2D(Collision2D collision) 
    {
        if (collision.collider.CompareTag("Ground") || collision.collider.CompareTag("Destroyable"))
        { 
            isGrounded = true; 
        } 
    }
    void OnCollisionExit2D(Collision2D collision) 
    {
        if (collision.collider.CompareTag("Ground")|| collision.collider.CompareTag("Ground1"))
        {
            isGrounded = false;
        }    
    }
    private void FixedUpdate()
    {   
        if(control == ControlVariant.PC)
        {
            if (Input.GetKey(KeyCode.A))
            {
                Move(Vector2.left);

                isMove = true;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                Move(Vector2.right);

                isMove = true;
            }
            else
            {
                isMove = false;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }
        else if (control == ControlVariant.MOBILE)
        {
            float horizontal = input.move.x;
            if (horizontal == 0)
            {
                isMove = false;
            }
            else 
            {
                isMove=true;
            }
            Vector2 direction = new Vector2(horizontal, 0);
            Move(direction);
            bool jumpPress = input.jump;
            if (jumpPress)
            {
                Jump();
            }
        }
        anim.SetBool("1_Move", isMove);
    }

    void Move(Vector2 direction)
    {
        rb.AddForce(direction * speed);
    }

    void Jump()
    {
        if (isGrounded == true)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    
}



