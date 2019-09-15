using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitAndDestroy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Boss")
        {
            coll.collider.gameObject.GetComponent<BadGuy>().Damage();
            Destroy(gameObject);
        }
        
    }
    IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSecondsRealtime(4);
        Destroy(gameObject);
    }
}
