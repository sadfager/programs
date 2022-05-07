using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class perehods1na2 : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)

    {
        if (collision.collider.tag == "kgh")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        


    }
}
