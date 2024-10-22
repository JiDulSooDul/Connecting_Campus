using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WatchScript : MonoBehaviour
{

    public GameObject WatchImage;

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Watch"))
		{
			WatchImage.gameObject.SetActive(true);
		}
	}
}
