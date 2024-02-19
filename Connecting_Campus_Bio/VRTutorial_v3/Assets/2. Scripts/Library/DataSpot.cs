using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataSpot : MonoBehaviour
{
    public GameObject panel;
    public Text txt;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("MainCamera") && HelperController.gameover)
        {
            panel.SetActive(true);
            txt.text = ("이곳은 검사한 신체 데이터를 바탕으로 시험약 성분을 분석하는 곳입니다.");
        }

        Invoke("activefalse", 10);

    }

    public void activefalse()
    {
        panel.SetActive(false);
    }

}
