using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChange : MonoBehaviour
{


    public void changelevel(int scenename)
    {
        Application.LoadLevel(scenename);
    }
}
