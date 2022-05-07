using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    static public int count = 0;
    public GameObject coinmini;
    public int k = 200;
    GameObject[] coin;
    void Start()
    {
        coin = new GameObject[k];
        for (int i = 0; i < k; i++)
        {
            coin[i] = Instantiate(coinmini);
            coin[i].transform.position = new Vector3(Random.Range(-1000f, 1000f), 20f, Random.Range(-1000f, 1000f));
        }
    }
}