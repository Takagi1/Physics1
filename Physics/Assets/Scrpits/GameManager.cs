using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // The Player
    public GameObject Player;

    // The Boss
    public GameObject Boss;

    // Update is called once per frame
    void Update()
    {
        if (Player.gameObject.GetComponent<Character>().Health == 0)
        {
            SceneManager.LoadScene("Loss", LoadSceneMode.Single);
        }

        if (Boss.gameObject.GetComponent<BadGuy>().Health == 0)
        {
            SceneManager.LoadScene("Victory", LoadSceneMode.Single);
        }
    }   
}
