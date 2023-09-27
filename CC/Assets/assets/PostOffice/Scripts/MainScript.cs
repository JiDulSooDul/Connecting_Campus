using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    public GameObject NPCDialog;
    
    void Start()
    {
        
        NPCDialog.SetActive(false);
    }

    public void NPCChatEnter()
    {
        NPCDialog.SetActive(true);
    }

    public void NPCChatExit()
    {
        NPCDialog.SetActive(false);
    }
}
