using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class watch : MonoBehaviour
{
    public GameObject Alert;
    public GameObject pill;
    void Start()
    {
        //Alert = GameObject.Find("UI");
        //pill = GameObject.Find("Pill Bottle");
        Alert.SetActive(false);
        pill.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Kiosk")
        {
            Alert.SetActive(true);
            pill.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Kiosk")
        {
            Alert.SetActive(false);
        }
    }
}
