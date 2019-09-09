using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    Animator anim;
    public float bulletDirection = 1;
    public float speed = 3.0f;
    public int damage = 5;
    int A;


    private Transform _transform;


    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        _transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet();
    }

    void MoveBullet()
    {
        float moveDirection = bulletDirection;

        float translate = moveDirection * speed * Time.deltaTime;
        _transform.Translate(translate, 0, 0);

    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        A = 1;
        a(0);
        if (coll.gameObject.tag == "baddy")
        {
            //coll.collider.gameObject.GetComponent<Enemy>().Damage(damage);
        }
    }
    void a(int b)
    {
        if (A == 1)
        {
            anim.SetBool("A", true);
        }
        if (b == 1)
        {
            Destroy(gameObject);
        }
    }

}
