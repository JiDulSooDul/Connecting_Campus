using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Watch : MonoBehaviour
{
    public GameObject Pill;
    public GameObject UI;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "door")
        {
            Debug.Log("Door trigger");
            SceneManager.LoadScene("ReMainGate");
            Time.timeScale = 1;
        }

        if (other.tag == "Kiosk")
        {
            Debug.Log("Recognize Watch");
            Pill.SetActive(true);
            UI.SetActive(true);
        }
    }
}
