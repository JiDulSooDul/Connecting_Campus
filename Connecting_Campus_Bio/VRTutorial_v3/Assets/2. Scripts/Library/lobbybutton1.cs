using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class lobbybutton1 : MonoBehaviour
{
    public GameObject lbbutton;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;


    private void Start()
    {
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!isPressed)
        {
            lbbutton.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject==presser)
        {
            lbbutton.transform.localPosition = new Vector3(0, 0.015f, 0);
            onRelease.Invoke();
            isPressed = false;
        }
    }

    public void goVR_Metaverse()
    {
        SceneManager.LoadScene("VR_Metaverse Conference Room");
    }
}
