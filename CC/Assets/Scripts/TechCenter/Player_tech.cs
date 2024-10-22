using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_tech : MonoBehaviour
{
    public GameObject Paper;
    private AudioSource doorSound;
    
    private void Start()
    {
        doorSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="door")
        {
            doorSound.Play(0);
            Debug.Log("Door trigger");
            
            Invoke("SceneChange", 2);
        }
    }

     private void OnTriggerExit(Collider other)
    {
        if (other.tag == "paper")
        {
            Debug.Log("release paper");
            //Paper.SetActive(false);
        }
    }
     
     void SceneChange()
     {
         SceneManager.LoadScene("ReMainGate");
     }
}
