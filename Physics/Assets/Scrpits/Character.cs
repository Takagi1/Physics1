using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
   
    //Body 
    private Rigidbody2D rigid;

    //Animation Controller
    Animator animator;

    //Player Health
    public int Health = 3;  //Set to 3 for basic health


    public float speed = 1; //Movment Speed 
    public float jump = 1; // Jump Speed

    // For player movement
    float translate;

    // Is Player on ground
    bool isGrounded;

    // Player location
    public Transform pos;

    // Player HurtBox
    public GameObject Hurtbox;

    private float PlayerDirection = 1; // player direction 1 is right, -1 is left
    
    void Start()
    {
        rigid = GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            //TODO Add in game over
        }
        //For player movement
        translate = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(translate, 0, 0);

        if (Input.GetKey(KeyCode.LeftArrow)) {
            print("left key was pressed");
            PlayerDirection = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            print("right key was pressed");
            PlayerDirection = 1;
        }

        // For Player Jump
        if (Input.GetKey(KeyCode.UpArrow) && isGrounded == true)
        {
            print("up key was pressed");
            rigid.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }

        //for sprite reverse
        if (PlayerDirection == 1)
        {
            this.transform.localScale = new Vector2(25, 50);
        }
        else
        {
            this.transform.localScale = new Vector2(-25, 50);
        }

        //For attacking
        if (Input.GetKey(KeyCode.X))
        {
            Attack1();
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            isGrounded = true;
        } else
        {
            isGrounded = false;
        }
    }

    void Attack1()
    {
        AttackOn();
        Instantiate(Hurtbox, pos.position, pos.rotation);
    }
    void AttackOn() { animator.SetBool("Attack1", true); }
    void AttackOff() { animator.SetBool("Attack1", false); }

    public void Damage()
    {
        Health -= 1;
    }
}
