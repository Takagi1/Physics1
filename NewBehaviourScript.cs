using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
   
    private Rigidbody2D rigid;
    private int attack;
    private int damage;
    
    void Start()
    {
        rigid = GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow){
            print("down key was pressed");
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow){
            print("up key was pressed");
        }
        
        if (Input.GetKey(KeyCode.LeftArrow) {
            print("left key was pressed");
        }

        if (Input.GetKey(KeyCode.RightArrow) {
            print("right key was pressed");
        }
    }
}
