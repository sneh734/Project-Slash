using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomEnemy : MonoBehaviour
{
    public float maxHealth = 1000f;
    public float currentHealth;
    public Animator animator;
    public GameObject FloatingDamage;
    public static MushroomEnemy instance;
    private bool alreadyExe = false;
    public bool isdead = false;

    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float stopRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb2d;

    public bool isMoving;
    public bool alreadyExe1 = false;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        FloatingDamage.GetComponent<TextMesh>();

    }

    public void Awake()
    {
        instance = this;
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);

        if (distToPlayer < agroRange)
        {
            ChasePlayer();
        }
        else
        {
            StopChasingPLayer();
        }

        if (isMoving == true)
        {
            animator.SetFloat("speed", 1f);
        }
        else if (isMoving == true)
        {
            animator.SetFloat("speed", 1f);
        }
        else if (isMoving == false)
        {
            animator.SetFloat("speed", -1f);
        }
    }


    public void TakeDamage(float damage)
    {
        if (!alreadyExe)
        {
            string Damage = damage.ToString();
            GameObject DamPop = Instantiate(FloatingDamage, transform.position, Quaternion.identity) as GameObject;
            DamPop.transform.GetChild(0).GetComponent<TextMesh>().text = Damage;
            animator.Play("Hurt");
            currentHealth -= damage;




            if (currentHealth <= 0)
            {
                Die();
                animator.Play("Die");

            }
        }

    }




    void StopChasingPLayer()
    {
        rb2d.velocity = new Vector2(0, 0);
        isMoving = false;
    }

    void ChasePlayer()
    {
        if (transform.position.x < player.position.x & !alreadyExe)
        {
            //move right

            rb2d.velocity = new Vector2(moveSpeed, 0);
            transform.localScale = new Vector2(1, 1);
            isMoving = true;
            if (MushroomEnemy.instance.isdead == true)
            {
                rb2d.velocity = new Vector2(0, 0);
                alreadyExe = true;
            }


        }
        else if (transform.position.x > player.position.x & !alreadyExe)
        {
            // move left

            rb2d.velocity = new Vector2(-moveSpeed, 0);
            transform.localScale = new Vector2(-1, 1);
            isMoving = true;
            if (MushroomEnemy.instance.isdead == true)
            {
                rb2d.velocity = new Vector2(0, 0);
                alreadyExe = true;
            }
        }
    }
    void Die()
    {
        alreadyExe = true;
        StartCoroutine(checkerSeocnds(0.5f));
        isdead = true;
        GetComponent<Collider2D>().isTrigger = false;
        this.enabled = false;



    }

    private IEnumerator checkerSeocnds(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        this.gameObject.SetActive(false);
    }


}
