using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuy : MonoBehaviour
{

    public int Health = 3; //set 3 as normal

    public GameObject Bullet;
    public Transform pos;

    // Start is called before the first frame update
    void Start()
    {
        //start attack coroutine
        StartCoroutine(Attack());
         
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Attack()
    {
        print(Time.time);
        Instantiate(Bullet, pos.position, pos.rotation);
        yield return new WaitForSecondsRealtime(4);
        StartCoroutine(Attack());
    }
}
