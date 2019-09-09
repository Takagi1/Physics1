using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip AttackSound, DeathSound, JumpSound, KillSound, PickupSound, RunSound;
    static AudioSource audioSrc;
       
    // Start is called before the first frame update
    void Start()
    {

        AttackSound = Resources.Load<AudioClip>("Attack");
        DeathSound = Resources.Load<AudioClip>("Death");
        JumpSound = Resources.Load<AudioClip>("Jump");
        KillSound = Resources.Load<AudioClip>("Kill");
        PickupSound = Resources.Load<AudioClip>("Pickup");
        RunSound = Resources.Load<AudioClip>("Run");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Playsound(string clip)
    {
        switch (clip)
        {
            case "Attack":
                audioSrc.PlayOneShot(AttackSound);
                break;
            case "Death":
                audioSrc.PlayOneShot(DeathSound);
                break;
            case "Jump":
                audioSrc.PlayOneShot(JumpSound);
                break;
            case "Kill":
                audioSrc.PlayOneShot(KillSound);
                break;
            case "Pickup":
                audioSrc.PlayOneShot(PickupSound);
                break;
            case "Run":
                audioSrc.PlayOneShot(RunSound);
                break;
        }
    }

}
