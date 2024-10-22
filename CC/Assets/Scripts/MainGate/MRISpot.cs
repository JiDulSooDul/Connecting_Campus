using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MRISpot : MonoBehaviour
{
    public GameObject panel;
    public Text txt;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("MainCamera") && HelperController.gameover)
        {
            panel.SetActive(true);
            txt.text = ("이곳은 MRI를 통한 정밀검사가 이루어지는 곳입니다.");
        }

        Invoke("activefalse", 3);

    }

    public void activefalse()
    {
        panel.SetActive(false);
    }
}
