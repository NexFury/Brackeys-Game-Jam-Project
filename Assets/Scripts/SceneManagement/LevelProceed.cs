using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelProceed : MonoBehaviour
{
    private int currentSceneIndex;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }
}
