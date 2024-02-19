using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Watch_tech : MonoBehaviour
{
    public GameObject Paper;
    private int cnt = 0;
    
    public GameObject Main_DNA;
    
    void Start()
    {
        //Main_DNA = GameObject.Find("Main_DNA");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="door")
        {
            Debug.Log("Door trigger");
            SceneManager.LoadScene("ReMainGate");
            Time.timeScale = 1;
        }
        
        if (other.tag == "DNA_device")
        {
            if(cnt == 0){
                Paper.SetActive(true);
                cnt++;
            }
            else
            {
                Main_DNA.GetComponent<Main_DNA>().NPCChatEnter("이미 진단서를 제공받았습니다.");
            }
        }
    }
}
