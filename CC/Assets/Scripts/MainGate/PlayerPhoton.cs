using UnityEngine;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class PlayerPhoton : MonoBehaviourPunCallbacks
{
    private Transform tr;
    public static Text nickName;
 
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        if(!photonView.IsMine)
        {
            return;
        }

        // this.transform.position = Vector3.MoveTowards(this.transform.position, GameObject.Find("PhotonZone").transform.position, Time.deltaTime * 10f);
        //this.transform.position = GameObject.Find("PhotonZone").transform.position;
        //this.transform.parent = Camera.main.transform;
    }
}