using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Princess_Movements : MonoBehaviour
{
    [SerializeField] private LayerMask PlatFormsLayerMask;
    public Animator animator;
    public CharacterController2D controller;
    float HorizontalMove = 0f;
    public float runspeed = 25f;
    private Rigidbody2D RigidBodyWaterPrincess;
    public float JumpVelocity = 5f;
    private BoxCollider2D boxCollider2D;
    bool isGorunded;
    public Transform GroundCheck;
    
    public void Start()
        {
            animator = GetComponent<Animator>();
        }

    public void Awake()
        {
            RigidBodyWaterPrincess = GetComponent<Rigidbody2D>();
        }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;

        if(Input.GetKeyDown(KeyCode.Space))
            {
                if(isGorunded)
                {
                    RigidBodyWaterPrincess.velocity = Vector2.up * JumpVelocity;
                    animator.Play("Water Jump");
                    
                }
            }
    }

     private void FixedUpdate()
            {   
                    controller.Move(HorizontalMove * Time.fixedDeltaTime, false, false);
                    // Animation Fro Running And vectore flipping.
                    animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));

                    // No Infinite Jump
                    isGorunded = Physics2D.OverlapCircle(GroundCheck.position, 0.3f, PlatFormsLayerMask);
            }
}
