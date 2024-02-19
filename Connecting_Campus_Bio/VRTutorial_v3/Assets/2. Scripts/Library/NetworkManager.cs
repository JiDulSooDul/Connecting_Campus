using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    private string gameVersion = "1.0";
    public string userId = "user1";
    public byte maxPlayer = 20;

    public GameObject playerPrefab;

    void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = false;
    }

    void Start()
    {
        PhotonNetwork.GameVersion = this.gameVersion;
        PhotonNetwork.NickName = userId;

        PhotonNetwork.ConnectUsingSettings();
    }


    public override void OnConnectedToMaster()
    {
        Debug.Log("Connect To Master");
        PhotonNetwork.JoinRandomRoom();
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("Failed Join room !!!");
        PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = this.maxPlayer });
    }
    public override void OnJoinedRoom()
    {
        Debug.Log("Joined Room !!!");


        // ī�޶��� ���� ��ġ
        Vector3 cameraPosition = Camera.main.transform.position;

        // ī�޶󿡼� -1 ������ŭ ������ ��ġ ���
        Vector3 playerSpawnPosition = cameraPosition - Camera.main.transform.forward * 1.0f;

        // "Player"�� �ش� ��ġ�� Instantiate
        GameObject playerObject = PhotonNetwork.Instantiate("Player", playerSpawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
        playerObject.transform.parent = Camera.main.transform;

    }

}

