using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;
using UnityEngine.XR;


public class Tteleport1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera")) // 카메라와 충돌 검사
        {
            // XR Origin을 찾아서 해당 위치를 변경
            GameObject xrOrigin = GameObject.Find("XR Origin"); // XR Origin은 실제로 사용 중인 이름으로 변경하세요.

            Vector3 originPosition = xrOrigin.transform.position;
            originPosition.y -= 3.76f;
            xrOrigin.transform.position = originPosition;
        }
    }
}
    
