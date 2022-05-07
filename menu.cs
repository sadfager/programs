using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if (PlayerPrefs.HasKey("c"))
        { PlayerPrefs.DeleteKey("c");
            int count = 0;
        }
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void PlayGame1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
}