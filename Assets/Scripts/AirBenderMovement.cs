using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirBenderMovement : MonoBehaviour
{
    // Start is called before the first fra

    [SerializeField] private LayerMask PlatFormsLayerMask;
    public Animator animator;
    public CharacterController2D controller;
    float HorizontalMove = 0f;
    public float runspeed = 40f;
    private Rigidbody2D RigidBodyAirBender;
    public float JumpVelocity = 5f;
    private BoxCollider2D boxCollider2D;
    bool isGorunded;
    public Transform GroundCheck;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

     public void Awake()
    {
        RigidBodyAirBender = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;

        if(Input.GetKeyDown(KeyCode.Space))
            {
                if(isGorunded)
                {
                    RigidBodyAirBender.velocity = Vector2.up * JumpVelocity;
                    animator.Play("AirJump");

                }
            }

    }

    private void FixedUpdate()
            {
                    controller.Move(HorizontalMove * Time.fixedDeltaTime, false, false);
                    // Animation Fro Running And vectore flipping.
                    animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));

                    // No Infinite Jump
                    isGorunded = Physics2D.OverlapCircle(GroundCheck.position, 0.4f, PlatFormsLayerMask);
            }
}
