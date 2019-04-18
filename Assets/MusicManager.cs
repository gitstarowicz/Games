using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this);
        audioSource = GetComponent<AudioSource>();
       
    }
    void Awake()
    {
        int numMusicPlayer = FindObjectsOfType<MusicManager>().Length;
        print("Number of music player in this scene" + numMusicPlayer);
        if (numMusicPlayer > 1)
            Destroy(gameObject);
        else
            DontDestroyOnLoad(this.gameObject);
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }

}