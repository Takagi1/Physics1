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

    private void OnTriggerStay2D(Collider2D coll)
    {
        print(coll.gameObject.tag);
        if (coll.gameObject.tag == "Boss")
        {
            print("hit check");
            coll.gameObject.GetComponent<BadGuy>().Damage();
            Destroy(gameObject);
        }
    }

    IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSecondsRealtime(100.5f);
        Destroy(this.gameObject);
    }
}
