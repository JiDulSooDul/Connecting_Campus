using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelperController : MonoBehaviour
{
    public GameObject helper;
    public GameObject panel;
    public Text ment;
    public GameObject cam;
    public GameObject spot;
    public GameObject spot1;
    public GameObject green;
    public GameObject red;
    public GameObject watchtxt;
    public Text watchment;
    public GameObject drpanel;
    public Text drment;
    public GameObject dr;
    public GameObject dr2;
    public GameObject drspot;
    public GameObject playersckt;
   

    bool txt1 = true;
    bool txt2 = true;
    bool txt3 = true;

    public static bool time = false;
    public static bool gameover = false;

    void Update()
    {
        Invoke("firsttxt", 5);
    }

    public void firsttxt()
    {
        if (txt1)
        {
            helper.GetComponent<HelperMove>().walk();
            ment.text = ("우선 웨어러블 기기를 통해 당신의 개인정보와 건강정보를 업로드해야합니다.\n 웨어러블 기기 인식을 위해 이동하겠습니다.");
            helper.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, spot.transform.position, Time.deltaTime * 2f);
            spot.transform.position = Vector3.MoveTowards(spot.transform.position, spot1.transform.position, Time.deltaTime * 1.7f);
        }

    }

    public void sectxt()
    {
       helper.transform.localEulerAngles = new Vector3(0f, -180f, 0f);
        
        txt1 = false;
        if(txt2)
        {
            ment.text = ("기기의 불빛이 나오는 센서에 당신의 웨어러블 기기를 놓아주세요.");
        }
        Invoke("activecontroll", 3);

    }

    public void activecontroll()
    {
        panel.SetActive(false);
    }

    public void watchzone()
    {
        watchtxt.SetActive(true);
        Invoke("readeffect", 1);
    }

    public void watchzoneexite()
    {
        watchtxt.SetActive(false);
        red.SetActive(true);
        green.SetActive(false);
    }

    public void readeffect()
    {
        red.SetActive(false);
        green.SetActive(true);
        watchment.text = ("알러지 반응이 \n 검출되었습니다.");
        Invoke("changetxt", 3);
    }

    public void changetxt()
    {
        drpanel.SetActive(true);
        Invoke("drtrue", 3);
    }

    public void drtrue()
    {
        dr2.SetActive(false);
        dr.SetActive(true);
        Invoke("timeout", 3);
    }

    public void timeout()
    {
        time = true;
    }

    public void playerzone()
    {
        dr.SetActive(false);
        if(txt3)
            drment.text = ("검사 시작하겠습니다. 자동으로 검사가 종료되오니, 잠시만 기다려주세요.");
        Invoke("falsement", 5);
    }

    public void falsement()
    {
        txt3 = false;
        drpanel.SetActive(false);
        Invoke("ending", 15);
    }

    public void ending()
    {
        drpanel.SetActive(true);
        dr2.SetActive(true);
        drment.text = ("검사 종료되었습니다. \n 시험약 제조기간이 조금 소요되므로 우체국으로 배송해 드리겠습니다. \n 수고하셨습니다.");
        playersckt.SetActive(false);
        gameover = true;

        Invoke("drfalse", 5);
    }

    public void drfalse()
    {
        drpanel.SetActive(false);
    }

}
