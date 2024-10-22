using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class doorscript : MonoBehaviour
{
    public GameObject objectB;
    //public GameObject objectb;
    //public float disableDuration = 2.0f; // ��Ȱ��ȭ�� ���� ���� �ð�

    private bool isObjectBDisabled = false;
    //private bool isObjectbDisabled = false;
    private float disableEndTime = 0.0f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Exit"))
            SceneManager.LoadScene("RemainGate"); // "mainGate"�� �� �̸��Դϴ�.
    }


    private void Update()
    {
        if (isObjectBDisabled)
        {
            objectB.SetActive(true); // B object�� �ٽ� Ȱ��ȭ
            isObjectBDisabled = false;
        }
    }
}
