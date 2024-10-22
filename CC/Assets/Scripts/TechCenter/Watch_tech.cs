using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watch_tech : MonoBehaviour
{
    public GameObject Paper;
    private int cnt = 0;
    private AudioSource _audioSource;
    public AudioClip beep;
    
    public GameObject Main_DNA;
    
    void Start()
    {
        //Main_DNA = GameObject.Find("Main_DNA");
        _audioSource = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "DNA_device")
        {
            _audioSource.clip = beep;
            _audioSource.Play(0);
            
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
