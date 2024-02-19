using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    // 사용자 위치 세팅하기 (포톤 있을때랑 없을떄 나눠서 )
    private void Awake() 
    {
        var _photonNetwork = FindObjectOfType<NetworkManager>();

        var _me = Camera.main.gameObject;

        if (_photonNetwork == null)
        {
            _me.gameObject.transform.root.position = gameObject.transform.position;
            _me.gameObject.transform.root.rotation = gameObject.transform.rotation;
        }
        else
        {
            // 적당히
        }

    }

}
