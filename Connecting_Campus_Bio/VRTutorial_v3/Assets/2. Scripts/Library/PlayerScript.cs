using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerScript : MonoBehaviour
{

	public GameObject Panel;
	//public GameObject Panel1;
	public GameObject Panel2;
	public GameObject Panel3;
	public GameObject Panel4;
	public GameObject Panel5;
	public GameObject Panel6;
	public GameObject WatchImage; 


	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("reception"))
		{
			Panel.gameObject.SetActive(true);
		}

		//if (collision.gameObject.CompareTag("ICT1"))
		//{
		//	Panel1.gameObject.SetActive(true);
		//}

		if (collision.gameObject.CompareTag("ICT2"))
		{
			Panel2.gameObject.SetActive(true);
		}

		if (collision.gameObject.CompareTag("ICT3"))
		{
			Panel3.gameObject.SetActive(true);
		}

		if (collision.gameObject.CompareTag("ICT4"))
		{
			Panel4.gameObject.SetActive(true);
		}

		if (collision.gameObject.CompareTag("Aging1"))
		{
			Panel5.gameObject.SetActive(true);
		}

		if (collision.gameObject.CompareTag("Aging2"))
		{
			Panel6.gameObject.SetActive(true);
		}

		if (collision.gameObject.CompareTag("Watch"))
		{
			WatchImage.gameObject.SetActive(true);
		}

		if (collision.gameObject.CompareTag("Move"))
		{
			SceneManager.LoadScene(10);
		}
	}

	void OnCollisionExit(Collision collision)
    {
		if (collision.gameObject.CompareTag("reception"))
		{
			Panel.gameObject.SetActive(false);
		}

		//if (collision.gameObject.CompareTag("ICT1"))
		//{
		//	Panel1.gameObject.SetActive(false);
		//}

		if (collision.gameObject.CompareTag("ICT2"))
		{
			Panel2.gameObject.SetActive(false);
		}

		if (collision.gameObject.CompareTag("ICT3"))
		{
			Panel3.gameObject.SetActive(false);
		}

		if (collision.gameObject.CompareTag("ICT4"))
		{
			Panel4.gameObject.SetActive(false);
		}

		if (collision.gameObject.CompareTag("Aging1"))
		{
			Panel5.gameObject.SetActive(false);
		}

		if (collision.gameObject.CompareTag("Aging2"))
		{
			Panel6.gameObject.SetActive(false);
		}

		if (collision.gameObject.CompareTag("Watch"))
		{
			WatchImage.gameObject.SetActive(false);
		}
	}
}
