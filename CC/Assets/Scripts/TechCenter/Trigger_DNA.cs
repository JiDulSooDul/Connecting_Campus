using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_DNA : MonoBehaviour
{
    public string ChatText = "";
    private GameObject Main_DNA;

    void Start()
    {
        Main_DNA = GameObject.Find("Main_DNA");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("NPC trigger");
            Main_DNA.GetComponent<Main_DNA>().NPCChatEnter(ChatText);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Main_DNA.GetComponent<Main_DNA>().NPCChatExit();
        }
    }
}
