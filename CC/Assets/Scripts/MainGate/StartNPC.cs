using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Experimental.Rendering.RenderGraphModule;


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

    public AudioSource narration;

    private void Start()
    {
        narration = GetComponent<AudioSource>();
    }

    void Awake()
    {
        Invoke("nextment", 20);
        Camera.main.gameObject.GetComponent<Camera>().cullingMask = 0;
        Camera.main.gameObject.GetComponent<Camera>().cullingMask |= 1 << LayerMask.NameToLayer("3DUI");
        Camera.main.gameObject.GetComponent<Camera>().clearFlags = CameraClearFlags.SolidColor;
        Camera.main.gameObject.GetComponent<Camera>().backgroundColor = new Color32(0, 0, 0, 0);
    }

    public void nextment()
    {
        Camera.main.gameObject.GetComponent<Camera>().cullingMask = -1;
        Camera.main.gameObject.GetComponent<Camera>().clearFlags = CameraClearFlags.Skybox;
        
        video.SetActive(false);
        if (textcheck)
            ment.text = "저는 캠퍼스 투어의 Helper입니다. 우선, 시선을 앞으로 고정해주시기 바랍니다.";
       Invoke("airtxt", 6);
    }

    public void airtxt()
    {
        textcheck = false;
        if(textcheck1)
            ment.text = "이 캠퍼스에서는 공기방울을 통해 이동할 수 있습니다. \n 이제 공기방울에 탑승하겠습니다.";
       // airball.transform.position = Vector3.MoveTowards(airball.transform.position, cam.transform.position, Time.deltaTime *200f);
        airball.GetComponent<Rigidbody>().AddForce(Vector3.forward * -300f);
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
        if (movecheck)
        {   // cam.transform.position = Vector3.MoveTowards(cam.transform.position, porespot.transform.position, Time.deltaTime * 100f);
            cam.GetComponent<Rigidbody>().AddForce(Vector3.forward * 2500f);
            cam.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0) * -500f);
          
        }



        Invoke("destroypore", 7);
    }

    public void destroypore()
    {
        cam.GetComponent<Rigidbody>().velocity = Vector3.zero;
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
        Invoke("destroypanel", 5);
    }

    public void destroypanel()
    {
        activecheck1 = false;
        panel.SetActive(false);
        helper.SetActive(false);
        
        narration.Play(0);
    }

}
