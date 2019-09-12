using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{


    public AudioSource BGM;

    public static AudioClip AttackSound, BossHitSound, JumpSound, LoseSound, PlayerHitSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        AttackSound = Resources.Load<AudioClip>("Attack");
        BossHitSound = Resources.Load<AudioClip>("BossHit");
        JumpSound = Resources.Load<AudioClip>("Jump");
        LoseSound = Resources.Load<AudioClip>("Lose");
        PlayerHitSound = Resources.Load<AudioClip>("PlayerHit");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeBGM(AudioClip music)
    {
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }

    public static void Playsound (string clip)
    {
        switch (clip)
        {
            case "Attack":
                audioSrc.PlayOneShot(AttackSound);
                break;
            case "BossHit":
                audioSrc.PlayOneShot(BossHitSound);
                break;
            case "Jump":
                audioSrc.PlayOneShot(JumpSound);
                break;
            case "Lose":
                audioSrc.PlayOneShot(LoseSound);
                break;
            case "PlayerHit":
                audioSrc.PlayOneShot(PlayerHitSound);
                break;
        }
    }
}
