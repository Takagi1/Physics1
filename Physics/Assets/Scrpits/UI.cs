using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    //for player
    public Text PlayerHealth;
    public GameObject Player;
    //for boss
    public Text BossHealth;
    public GameObject Boss;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       PlayerHealth.text = "Player: " + Player.GetComponent<Character>().Health;
       BossHealth.text = "Boss " + Boss.GetComponent<BadGuy>().Health;
    }


}
