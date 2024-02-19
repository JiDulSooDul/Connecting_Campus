using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class doorscript : MonoBehaviour
{
    public GameObject objectB;
    //public GameObject objectb;
    //public float disableDuration = 2.0f; // 비활성화된 상태 유지 시간

    private bool isObjectBDisabled = false;
    //private bool isObjectbDisabled = false;
    private float disableEndTime = 0.0f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Exit"))
            SceneManager.LoadScene("ReMainGate"); // "mainGate"는 씬 이름입니다.
    }


    private void Update()
    {
        if (isObjectBDisabled)
        {
            objectB.SetActive(true); // B object를 다시 활성화
            isObjectBDisabled = false;
        }
    }
}
