using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{

    public float autoLoadNextLevelAfter;

    void Start()
    {
        if (autoLoadNextLevelAfter <= 0)
        {
            Debug.Log("Level auto load disabled,use a postive number is seconds");
        }
        else
        {
            Invoke("LoadNextLevel1", autoLoadNextLevelAfter);
        }
    }
    public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for:" + name);
        Application.LoadLevel(name);
    }
    public void QuiteRequest()
    {
        Debug.Log("I Want to quit");
        Application.Quit();
    }
    public void LoadNextLevel1()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
