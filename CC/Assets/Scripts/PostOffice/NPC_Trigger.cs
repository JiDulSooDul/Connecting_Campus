using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Trigger : MonoBehaviour
{
    //public string ChatText = "";
    public GameObject Main;
    public GameObject UI;

    void Start()
    {
        //Main = GameObject.Find("Main");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Watch")
        {
            Debug.Log("NPC trigger");
            Main.GetComponent<Main>().NPCChatEnter();
            UI.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Watch")
        {
            Main.GetComponent<Main>().NPCChatExit();
        }
    }
}