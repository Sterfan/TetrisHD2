using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    private bool facingRight = true;

    public Animator animator;
    private bool isMoving = false;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    public AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxisRaw("Horizontal");
        if (rb.velocity.x != 0)
            isMoving = true;
        
        else
            isMoving = false;

        if (isMoving && isGrounded)
        {
            if (!audioSrc.isPlaying)
                audioSrc.Play();
        }
        else
            audioSrc.Stop();

        if (isMoving == true)
        {
            Debug.Log("Moving is true!");
        }
        else
        {
            Debug.Log("moving is false");
        }
            


        
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        animator.SetFloat("Zpeed", Mathf.Abs(moveInput));

        if(facingRight == false && moveInput > 0)
        {
            Flip();
        }else if(facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }

    private void Update()
    {

        if(isGrounded == true)
        {
            animator.SetBool("Jump", false);

            if (Input.GetKeyDown(KeyCode.W))
            {
                
                rb.velocity = Vector2.up * jumpForce;
                AudioManager.PlayMusic("pl_jump");
            }
        }
            if(isGrounded == false)
            {
            animator.SetBool("Jump", true);
        }
    }


    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
