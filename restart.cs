using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class restart : MonoBehaviour
{
    

   
    public void  RestartLevel()
    {
        
        { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+0); }

    }
}
