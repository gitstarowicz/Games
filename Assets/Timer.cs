using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public string levelLoad;
    private float timer = 19f;
    private Text timerSecounds;

	// Use this for initialization
	void Start ()
    {
        timerSecounds = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;
        timerSecounds.text = timer.ToString("f0");
        if(timer <= 0 )
        {
            SceneManager.LoadScene(4);
        }
		
	}
}
