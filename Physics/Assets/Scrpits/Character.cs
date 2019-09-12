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
    public int Health = 1;  //Set to 3 for basic health
    public float speed = 1; //Movment Speed 
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
        if (Input.GetKey(KeyCode.LeftArrow)) {
            print("left key was pressed");
            rigid.velocity = new Vector2((speed*-1), 0);
            PlayerDirection = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            print("right key was pressed");
            rigid.velocity = new Vector2(speed, 0);
            PlayerDirection = 1;
        } else {
            rigid.velocity = new Vector2(0, 0);
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

    void Attack1()
    {
        AttackOn();
    }
    void AttackOn() { animator.SetBool("Attack1", true); }
    void AttackOff() { animator.SetBool("Attack1", false); }
}
