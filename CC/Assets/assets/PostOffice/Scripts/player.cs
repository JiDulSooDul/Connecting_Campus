using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
 
 
public class player : MonoBehaviour
{
    public GameObject Pill;
    void Start()
    {
        //Pill = GameObject.Find("Pill Bottle");
    }
    
    
    private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("door"))
            {
                SceneManager.LoadScene("Main");
                Time.timeScale = 1;
            }

            if (collision.gameObject.CompareTag("pill"))
            {
                Time.timeScale = 1;
                Pill.SetActive(false);
            }
        }
}
