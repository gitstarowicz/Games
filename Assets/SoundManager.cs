using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static AudioClip  FireSound, WalkSound, EnemyDeathSound;
    static AudioSource audioSrc;




	// Use this for initialization
	void Start () {
        WalkSound = Resources.Load<AudioClip>("fire1");
        FireSound = Resources.Load<AudioClip>("fire");
        //EnemyDeathSound = Resources.Load<AudioClip>("Edeath");

   audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void Update()  {
        
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "fire1":
                //  StepsSound.Play();
             audioSrc.PlayOneShot(WalkSound);
               break;
            case "fire":
                audioSrc.PlayOneShot(FireSound);
                break;
           // case "Edeath":
               // audioSrc.PlayOneShot(EnemyDeathSound);
               // break;
        }
      
    }
}
