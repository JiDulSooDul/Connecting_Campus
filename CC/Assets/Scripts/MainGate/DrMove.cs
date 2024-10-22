using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrMove : MonoBehaviour
{
    public GameObject drspot;
    public Text drment;

    private Animator stop;

    private void Start()
    {
        stop = GetComponent<Animator>();
    }

    void Update()
    {
        this.transform.localEulerAngles = new Vector3(0f, 90f, 0f);
        this.transform.position = Vector3.MoveTowards(this.transform.position, drspot.transform.position, Time.deltaTime * 0.7f);

        if(HelperController.time)
            stop.SetTrigger("stopwalk");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("MainCamera"))
        {
            this.transform.localEulerAngles = new Vector3(0f, 180f, 0f);

            drment.text = ("검사를 위해 오른쪽에 보이는 베드로 가주세요. ");
        }
    }
}
