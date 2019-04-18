using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisionHeader : MonoBehaviour {

    void Start()
    {

    }

    void OnTriggerEnter(Collider Enemy)
    {
        if (Enemy.gameObject.tag == "Finish")
        {
            WinLevel();
        }
        else if (Enemy.gameObject.tag == "Finish1")
        {
            WinLevel1();
        }
        else if (Enemy.gameObject.tag == "Finish2")
        {
            WinLevel2();
        }
        
    }

    private void DeathSequence()
    {
        //   SendMessage("OnPlayerDeath");
    }
    private void ReloadScene()
    {
        SceneManager.LoadScene(9);
    }
    private void ReloadScene1()
    {
        SceneManager.LoadScene(11);
    }
    private void ReloadScene2()
    {
        SceneManager.LoadScene(13);
        
    }
    private void WinLevel()
    {
        Debug.Log("Dziala");
        SceneManager.LoadScene(3);
    }
    private void WinLevel1()
    {
        SceneManager.LoadScene(8);
    }
    private void WinLevel2()
    {
        SceneManager.LoadScene(12);
    }
    public void LoseHit()
    {

    }


}
