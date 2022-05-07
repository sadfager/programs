


using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class time : MonoBehaviour
{
    
    public Text k;
    public static bool PauseGame;
    public GameObject pauseMenu;
    public float t = 0;
    int m = 0;
    int z = 0;
   

    private void OnCollisionEnter(Collision collision)

    {
        if (collision.collider.tag == "ccoin")
        {
            Destroy(collision.gameObject);
            m += 1;

            
        }
        if (m == 6)
        { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); }



    }







    void Update()
    {
        if (m >= 1)
        {
            t = t + Time.deltaTime;

            k.text =string.Format("{0:00}", "" + t);
        }
        if (t >= 60) 
        { z += 1; }
        if (z==1)
        {
            
            
                Pause();
            
        }
       
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;

    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }


}





