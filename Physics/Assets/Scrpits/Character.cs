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


    public float speed = 25; //Movment Speed 
    public float jump = 100; // Jump Speed

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
        //For player movement
        translate = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(translate, 0, 0);

        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            PlayerDirection = -1;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            PlayerDirection = 1;
        }

        // For Player Jump
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded == true)
        {
            rigid.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
            isGrounded = false;
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
        if (Input.GetKeyDown(KeyCode.X))
        {
            Attack1();
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void Attack1()
    {
        AttackOn();
        Instantiate(Hurtbox, new Vector3 (pos.position.x + 10, pos.position.y, pos.position.z), pos.rotation);
    }

    public void restartPos()
    {
        transform.position = new Vector2(-104.4f, -16.3f);
    }


    void AttackOn() { animator.SetBool("Attack1", true); }
    void AttackOff() { animator.SetBool("Attack1", false); }

    public void Damage()
    {
        Health -= 1;
    }
}
