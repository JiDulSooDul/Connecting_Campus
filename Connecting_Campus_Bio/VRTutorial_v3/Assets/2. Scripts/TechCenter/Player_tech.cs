using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_tech : MonoBehaviour
{
    public GameObject Paper;
    private void OnTriggerEnter(Collider other)
    {
        
    }

     private void OnTriggerExit(Collider other)
    {
        if (other.tag == "paper")
        {
            Debug.Log("release paper");
            //Paper.SetActive(false);
        }
    }
}
