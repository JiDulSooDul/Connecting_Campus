using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class Watch : MonoBehaviour
{
    public GameObject Pill;
    public GameObject UI;

    private AudioSource _audioSource;
    public AudioClip doorSound;
    public AudioClip kioskSound;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "door")
        {
            _audioSource.clip = doorSound;
            _audioSource.Play(0);
            Debug.Log("Door trigger");
            
            Invoke("SceneChange", 1f);
        }

        if (other.tag == "Kiosk")
        {
            _audioSource.clip = kioskSound;
            _audioSource.Play(0);
            Debug.Log("Recognize Watch");
            Pill.SetActive(true);
            UI.SetActive(true);
        }
    }

    void SceneChange()
    {
        SceneManager.LoadScene("ReMainGate");
    }
}
