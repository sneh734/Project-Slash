using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingsMovements : MonoBehaviour
{
    

      
    [SerializeField] private LayerMask PlatFormsLayerMask;
    public Animator animator;
    public CharacterController2D controller;
    float HorizontalMove = 0f;
    public float runspeed = 40f;
    private Rigidbody2D RigidBodyKing;
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
        RigidBodyKing = GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame depends on frame buffer input. More frames more executions of the function Update. 
    private void Update()
    {   
             // Player Movement / PLayer Invert when mocing left or right of the sprite
        HorizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;

        if(Input.GetKeyDown(KeyCode.Space))
            {
                if(isGorunded)
                {
                    RigidBodyKing.velocity = Vector2.up * JumpVelocity;
                    animator.Play("King Jump");
                    
                }
            }
    }
    

    // Fixed Updates: Only updates every certain amount of time more deterministic.
        private void FixedUpdate()
            {   
                    controller.Move(HorizontalMove * Time.fixedDeltaTime, false, false);
                    // Animation Fro Running And vectore flipping.
                    animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));

                    // No Infinite Jump
                    isGorunded = Physics2D.OverlapCircle(GroundCheck.position, 0.2f, PlatFormsLayerMask);
            }


        
        
}


            
    
    
