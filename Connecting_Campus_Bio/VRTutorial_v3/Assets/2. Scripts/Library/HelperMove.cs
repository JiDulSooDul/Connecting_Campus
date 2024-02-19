using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HelperMove : MonoBehaviour
{
    private Animator walkanim;
    public GameObject GC;

    private void Start()
    {
        walkanim = GetComponent<Animator>();
    }

    public void walk()
    {
        walkanim.SetTrigger("gowalk");
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("trigger"))
        {
            walkanim.SetTrigger("stopwalk");
            GC.GetComponent<HelperController>().sectxt();

        }


    }


}
