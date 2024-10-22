using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class AirController : MonoBehaviour
{
    public GameObject airmaterial;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("MainCamera"))
        {
            airmaterial.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
