using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip Attack, Death, Jump, Kill, Pickup, Run;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        Attack = Resources.Load<AudioClip>("Attack");
        Death = Resources.Load<AudioClip>("Death");
        Jump = Resources.Load<AudioClip>("Jump");
        Kill = Resources.Load<AudioClip>("Kill");
        Pickup = Resources.Load<AudioClip>("Pickup");
        Run = Resources.Load<AudioClip>("Run");

        audioSrc = GetComponent<AudioSource>();
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
                audioSrc.PlayOneShot(Attack);
                break;
            case "Death":
                audioSrc.PlayOneShot(Death);
                break;
            case "Jump":
                audioSrc.PlayOneShot(Jump);
                break;
            case "Kill":
                audioSrc.PlayOneShot(Kill);
                break;
            case "Pickup":
                audioSrc.PlayOneShot(Pickup);
                break;
            case "Run":
                audioSrc.PlayOneShot(Run);
                break;
        }
    }

}
