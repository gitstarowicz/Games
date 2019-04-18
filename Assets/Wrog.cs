using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wrog : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject);
        Debug.Log("Udrzenie");
       
    }
}