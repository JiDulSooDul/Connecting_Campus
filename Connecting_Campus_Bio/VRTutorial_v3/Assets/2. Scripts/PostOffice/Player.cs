using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject Pill;
    private void OnTriggerEnter(Collider other)
    {
        /*
        if (other.tag == "door")
        {
            Debug.Log("Door trigger");
            SceneManager.LoadScene("MainGate");
            //Time.timeScale = 1;
        }
        */
        if (other.tag == "pill")
        {
            Debug.Log("Get Pill");
            Time.timeScale = 0.5f;
            Pill.SetActive(false);
        }
    }
}
