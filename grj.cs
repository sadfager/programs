using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class grj : MonoBehaviour
{ int count=0;
    public Text k;
    public GameObject perevod;
  
    void Start()

   
    {
        if (PlayerPrefs.HasKey("c"))
        { count=PlayerPrefs.GetInt("c");
            k.text = "Вы собрали " + count + ",осталось " + (100 - count) + " монет";
        }
        

    }

    private void OnCollisionEnter(Collision collision)
       
    { if (collision.collider.tag == "coin")
        {
            Destroy(collision.gameObject);
            count++;
            PlayerPrefs.SetInt("c", count);
            PlayerPrefs.Save();



        }
        Debug.Log(count);
        k.text = "Вы собрали "+count+",осталось "+(100-count)+" монет";
       

        if (count >= 100)
        { k.text = "Теперь найдите светящуюся монету";
            perevod.SetActive(true);
            
        }
    }
}
