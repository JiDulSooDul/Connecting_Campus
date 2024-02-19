using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestSpot : MonoBehaviour
{
    public GameObject panel;
    public Text txt;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("MainCamera") && HelperController.gameover)
        {
            panel.SetActive(true);
            txt.text = ("이곳은 정밀검사가 진행되는 공간입니다. \n 현재 검사 중이니 다음에 방문해 주세요.");
        }

        Invoke("activefalse", 3);

    }

    public void activefalse()
    {
        panel.SetActive(false);
    }
}
