using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public GameObject NPCDialog;
    //private Text NPCText;

    void Start()
    {
        //NPCDialog = GameObject.Find("NPCDialog");
        //NPCText = GameObject.Find("NPCText").GetComponent<Text>();
        //NPCDialog.SetActive(false);
    }

    public void NPCChatEnter()
    {
        //NPCText.text = text;
        NPCDialog.SetActive(true);
    }

    public void NPCChatExit()
    {
        //NPCText.text = "";
        NPCDialog.SetActive(false);
    }    
}
