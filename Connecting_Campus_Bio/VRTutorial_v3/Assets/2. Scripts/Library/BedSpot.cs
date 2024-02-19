using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BedSpot : MonoBehaviour
{
    public GameObject panel;
    public Text txt;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("MainCamera") && HelperController.gameover)
        {
            panel.SetActive(true);
            txt.text = ("이곳은 아픈 학생들이 쉬는 곳입니다. ");
        }

        Invoke("activefalse", 3);

    }

    public void activefalse()
    {
        panel.SetActive(false);
    }

}
