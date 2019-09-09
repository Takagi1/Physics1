using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
   
    //Body 
    private Rigidbody2D rigid;
    //Attack
    public GameObject bullet;

    public float speed = 1;
    private float PlayerDirection = 1;
    
    void Start()
    {
        rigid = GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            print("left key was pressed");
            rigid.velocity = new Vector2((speed*-1), 0);
            PlayerDirection = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            print("right key was pressed");
            rigid.velocity = new Vector2(speed, 0);
            PlayerDirection = 1;
        }

        if (Input.GetKey(KeyCode.X))
        {
            Attack();
        }
    }

    public void Attack()
    {
        var tBullet = Instantiate(bullet, gameObject.transform.position, bullet.transform.rotation) as GameObject;
        tBullet.GetComponent<Bullet>().bulletDirection = PlayerDirection;
    }
}
