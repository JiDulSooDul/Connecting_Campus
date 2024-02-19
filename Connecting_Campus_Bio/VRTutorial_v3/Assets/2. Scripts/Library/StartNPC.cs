using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartNPC : MonoBehaviour
{
    public GameObject helper;
    public GameObject panel;
    public GameObject cell;
    public Text ment;
    public GameObject cam;
    public GameObject pore;
    public GameObject porespot;
    public GameObject airball;
    public GameObject airmaterial;
    public GameObject watch;
    public GameObject video;

    bool movecheck = true;
    bool textcheck = true;
    bool textcheck1 = true;
    bool textcheck2 = true;
    bool textcheck3 = true;
    bool activecheck = true;
    bool activecheck1 = true;

    void Update()
    {
        Invoke("nextment", 20);
    }

    public void nextment()
    {
        video.SetActive(false);
        if (textcheck)
            ment.text = "저는 캠퍼스 투어의 Helper입니다.";
       Invoke("airtxt", 3);
    }

    public void airtxt()
    {
        textcheck = false;
        if(textcheck1)
            ment.text = "이 캠퍼스에서는 공기방울을 통해 이동할 수 있습니다. \n 이제 공기방울에 탑승하겠습니다.";
        airball.transform.position = Vector3.MoveTowards(airball.transform.position, cam.transform.position, Time.deltaTime *7f);
        Invoke("air", 5);
    }

    public void air()
    {
        airball.SetActive(false);
        airmaterial.SetActive(true);
        Invoke("nextment1", 3);
    }

    public void nextment1()
    {
        textcheck1 = false;
        if(textcheck2)
            ment.text = "지금부터 앞에 보이는 기공을 통과해 \n 캠퍼스로 이동하겠습니다!";
        Invoke("next", 5);
    }

    public void next()
    {
        if (activecheck)
        {
            helper.SetActive(false);
            panel.SetActive(false);
        }
        Invoke("moveto", 1);
    }

    public void moveto()
    {
        if(movecheck)
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, porespot.transform.position, Time.deltaTime * 100f);

        Invoke("destroypore", 5);
    }

    public void destroypore()
    {
        movecheck = false;
        Destroy(pore.gameObject);
        Invoke("watchtxt", 1);
    }

    public void watchtxt()
    {
        activecheck = false;
        textcheck2 = false;
        if (activecheck1)
        {
            panel.SetActive(true);
            helper.SetActive(true);
        }
        ment.fontSize = 5;
        if(textcheck3)
            ment.text = "캠퍼스 투어를 위해 당신의 신체정보를 \n제공받고자 합니다.\n\n앞에 보이는 스마트 워치를 팔에 착용해 주세요.";
        watch.SetActive(true);
    }

    public void nextmovetext()
    {
        textcheck3 = false;
        ment.text = "원하는 장소의 표지판을 클릭하면\n캠퍼스 내부로 이동할 수 있습니다.\n\n준비가 되면 투어를 시작하세요!";
        Invoke("destroypanel", 2);
    }

    public void destroypanel()
    {
        activecheck1 = false;
        panel.SetActive(false);
        helper.SetActive(false);
    }

}
