using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
 
 
public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
        {
            
            if (collision.gameObject.CompareTag("Door"))
            {
                SceneManager.LoadScene("Main");
                Time.timeScale = 1;
            }
        }
}
