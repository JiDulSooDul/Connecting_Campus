using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class button2 : MonoBehaviour
{
    public  GameObject Info2;

    public void Press()
    {
        if (Info2.activeSelf)
            Info2.gameObject.SetActive(false);
        else
            Info2.gameObject.SetActive(true);
    }
}
