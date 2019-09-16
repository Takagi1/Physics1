using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    float moveDirection = -1;
    public float speed = 5.0f;
    int A;

    private Transform _transform;


    // Use this for initialization
    void Start()
    {
        _transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet();
    }

    void MoveBullet()
    {
        float translate = moveDirection * speed * Time.deltaTime;
        _transform.Translate(translate, 0, 0);

    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            
            coll.gameObject.GetComponent<Character>().Damage();
            Destroy(gameObject);
        }
    }

}
