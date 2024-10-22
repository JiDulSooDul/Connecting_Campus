using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main_DNA : MonoBehaviour
{
    public GameObject NPCDialog_DNA;
    public GameObject NPCText_DNA;
    private Text NPCText;
    
    void Start()
    {
        //NPCDialog = GameObject.Find("NPCDialog");
        NPCText = NPCText_DNA.GetComponent<Text>();
        NPCDialog_DNA.SetActive(false);
    }

    public void NPCChatEnter(string text)
    {
        NPCText.text = text;
        NPCDialog_DNA.SetActive(true);
    }

    public void NPCChatExit()
    {
        NPCText.text = "";
        NPCDialog_DNA.SetActive(false);
    }    
}