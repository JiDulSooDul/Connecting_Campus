using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class button1 : MonoBehaviour
{
    public GameObject Info1;
    bool info2off = false;

    public void Press()
    {
        if(Info1.activeSelf )
            Info1.gameObject.SetActive(false);
        else
            Info1.gameObject.SetActive(true);

    }
}
