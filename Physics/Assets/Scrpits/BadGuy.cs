using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuy : MonoBehaviour
{

    public int Health = 3; //set 3 as normal

    Animator animator; //For animation
    // For random height
    Random random;

    public GameObject Bullet;
    public Transform pos;

    public GameObject Player;

    int min = 1;
    int max = 20;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); // get the animator

        random = new Random();
        //start attack coroutine
        StartCoroutine(Attack());
         
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator Attack()
    {
        Fire(Random.Range(min, max));
        print("random text" + Random.Range(min, max));
        yield return new WaitForSecondsRealtime(2.5f);
        StartCoroutine(Attack());
    }

    void UpAttack() { }

    void Fire(int Height) {
        if (Height >= 10)
        {
            Instantiate(Bullet, new Vector3(pos.position.x - 25, pos.position.y, pos.position.z), pos.rotation);
            animator.SetBool("Up", true);
        } else
        {
            Instantiate(Bullet, new Vector3 (pos.position.x - 30, pos.position.y - 15, pos.position.z), pos.rotation);
            animator.SetBool("Down", true);
        }
    }

    public void Damage()
    {
        Health -= 1;
        Player.GetComponent<Character>().restartPos();
    }

    void UpOff() { animator.SetBool("Up", false); }
    void DownOff() { animator.SetBool("Down", false); }
}
