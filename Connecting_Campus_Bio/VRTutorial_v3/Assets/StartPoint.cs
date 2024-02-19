using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    // ����� ��ġ �����ϱ� (���� �������� ������ ������ )
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
            // ������
        }

    }

}
