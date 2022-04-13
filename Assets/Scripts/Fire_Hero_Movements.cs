using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Hero_Movements : MonoBehaviour
{
    [SerializeField] private LayerMask PlatFormsLayerMask;
    public Animator animator;
    public CharacterController2D controller;
    public float HorizontalMove = 0f;
    public float runspeed = 40f;
    private Rigidbody2D RigidBodyKing;
    public float JumpVelocity = 5f;
    private BoxCollider2D boxCollider2D;
    public bool isGorunded;
    public Transform GroundCheck;
    public static Fire_Hero_Movements instance;

        
    // Start is called before the first frame update

    public void Start()
    {
        animator = GetComponent<Animator>();
       
       
    }

    public void Awake()
    {
        RigidBodyKing = GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;

        if(Input.GetKeyDown(KeyCode.Space))
            {
                if(isGorunded)
                {
                    animator.Play("Fire Hero Jump"); 
                    RigidBodyKing.velocity = Vector2.up * JumpVelocity;

                     
                    
                }
            }
    }

    private void FixedUpdate()
            {
                
 
                    controller.Move(HorizontalMove * Time.fixedDeltaTime, false, false);
                     // Animation For Running And vectore flipping.
                    
                     animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));
                    // No Infinite Jump
                    isGorunded = Physics2D.OverlapCircle(GroundCheck.position, 0.2f, PlatFormsLayerMask);

                   

    }
}

