using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Trigger : MonoBehaviour
{
    //public string ChatText = "";
    public GameObject Main;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Main.GetComponent<MainScript>().NPCChatEnter();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Main.GetComponent<MainScript>().NPCChatExit();
        }
    }
}
