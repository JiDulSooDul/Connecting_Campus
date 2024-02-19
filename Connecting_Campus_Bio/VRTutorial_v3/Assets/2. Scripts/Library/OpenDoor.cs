using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
	public GameObject LG_Door_01;
	public GameObject LG_Door_02;
	public GameObject LG_Door_03;
	public GameObject LG_Door_04;
	public GameObject gate_l;
	public GameObject gate_r;
	public GameObject leg;
	public GameObject leg2;

	public AudioClip OpenSound;
	public AudioClip CloseSound;

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("ICTDOOR"))
		{
			LG_Door_01.gameObject.SetActive(false);
			LG_Door_02.gameObject.SetActive(false);
			leg.gameObject.SetActive(false);
			AudioSource.PlayClipAtPoint(OpenSound, transform.position);
		}

		if (collision.gameObject.CompareTag("ICTDOOR2")) 
		{
			LG_Door_03.gameObject.SetActive(false);
			LG_Door_04.gameObject.SetActive(false);
			AudioSource.PlayClipAtPoint(OpenSound, transform.position);
		}

		if (collision.gameObject.CompareTag("AgingDoor"))
		{
			gate_l.gameObject.SetActive(false);
			gate_r.gameObject.SetActive(false);
			leg2.gameObject.SetActive(false);
			AudioSource.PlayClipAtPoint(OpenSound, transform.position);
		}

	}

	void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.CompareTag("ICTDOOR"))
		{
			LG_Door_01.gameObject.SetActive(true);
			LG_Door_02.gameObject.SetActive(true);
			leg.gameObject.SetActive(true);
			AudioSource.PlayClipAtPoint(CloseSound, transform.position);
		}

		if (collision.gameObject.CompareTag("ICTDOOR2"))
        {
			LG_Door_03.gameObject.SetActive(true);
			LG_Door_04.gameObject.SetActive(true);
			AudioSource.PlayClipAtPoint(CloseSound, transform.position);
		}

		if (collision.gameObject.CompareTag("AgingDoor"))
		{
			gate_l.gameObject.SetActive(true);
			gate_r.gameObject.SetActive(true);
			leg2.gameObject.SetActive(true);
			AudioSource.PlayClipAtPoint(CloseSound, transform.position);
		}

	}
}
