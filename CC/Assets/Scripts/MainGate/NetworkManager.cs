using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    private string gameVersion = "1.0";
    public string userId = "";
    public byte maxPlayer = 10;

    // �Ⱦ��Ű���
    public GameObject jieun; // user1 extra���� ������. 
    public GameObject jisoo; 
    public GameObject HanSubin;
    public GameObject KimSubin;

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

// 카메라를 찾고 해당 위치를 가져옵니다.
        Camera mainCamera = Camera.main;
        Vector3 cameraPosition = mainCamera.transform.position;

        // 카메라 앞에 플레이어 스폰 위치를 계산합니다.
        Vector3 playerSpawnPosition = cameraPosition - mainCamera.transform.forward * 1.0f;

        // 플레이어 오브젝트를 생성합니다.
        GameObject playerObject = PhotonNetwork.Instantiate(userId, playerSpawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));

        // 플레이어 오브젝트를 카메라의 자식으로 설정합니다.
        playerObject.transform.SetParent(mainCamera.transform, false); // 두 번째 인자는 worldPositionStays로, 이 값이 false이면 로컬 위치를 유지합니다.
    }


    public GameObject GetPlayerPrefab(string _prefabName)
    {
        if(_prefabName == "jisoo")
        {
            return jisoo;
        }
        else if (_prefabName == "jieun")
        {
            return jieun;
        }
        else if (_prefabName == "HanSubin")
        {
            return HanSubin;
        }
        else if (_prefabName == "KimSubin")
        {
            return KimSubin;
        }
        return null;
    }

}

