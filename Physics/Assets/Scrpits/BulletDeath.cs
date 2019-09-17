using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDeath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll)
    {
        print(coll.gameObject.tag);
        if (coll.gameObject.tag == "Bullet")
        {
            print("hit check");
            Destroy(coll.gameObject);
        }
    }
}
