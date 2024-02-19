using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class librarybutton : MonoBehaviour
{
    public GameObject lbbutton;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isObjectAActive = true; // 초기 상태 설정

    public GameObject objectA1;
    public GameObject objectB1;

    private void OnTriggerEnter(Collider other)
    {
        if (isObjectAActive)
        {
            objectA1.SetActive(false);
            objectB1.SetActive(true);
        }
        else
        {
            objectA1.SetActive(true);
            objectB1.SetActive(false);
        }

        // 상태 변경 후 현재 상태 반전
        isObjectAActive = !isObjectAActive;

        lbbutton.transform.localPosition = new Vector3(-0.8780003f, -0.3f, 0.8710001f);
        presser = other.gameObject;
        onPress.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            lbbutton.transform.localPosition = new Vector3(-0.8780003f, -0.27f, 0.8710001f);
            onRelease.Invoke();
        }
    }
}

