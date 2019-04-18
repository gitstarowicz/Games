using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour {

    public void doquite()
    {
        Application.Quit();
        Debug.Log("koniec");
    }
}