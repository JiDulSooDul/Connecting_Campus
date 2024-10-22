using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;


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

	AudioSource audio;
	public AudioClip moveSound;

	private void Start()
	{
		audio = GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag=="reception")
		{
			Panel.gameObject.SetActive(true);
		}

		//if (collision.gameObject.CompareTag("ICT1"))
		//{
		//	Panel1.gameObject.SetActive(true);
		//}

		if (other.tag=="ICT2")
		{
			Panel2.gameObject.SetActive(true);
		}

		if (other.tag=="ICT3")
		{
			Panel3.gameObject.SetActive(true);
		}

		if (other.tag=="ICT4")
		{
			Panel4.gameObject.SetActive(true);
		}

		if (other.tag=="Aging1")
		{
			Panel5.gameObject.SetActive(true);
		}

		if (other.tag=="Aging2")
		{
			Panel6.gameObject.SetActive(true);
		}

		if (other.tag=="Watch")
		{
			WatchImage.gameObject.SetActive(true);
		}

		if (other.tag=="Move")
		{
			audio.clip = moveSound;
			audio.Play(0);
			Invoke("Scene", 2);
		}
	}

	void Scene()
	{
		SceneManager.LoadScene(10);
	}

	void OnTriggerExit(Collider other)
    {
		if (other.tag=="reception")
		{
			Panel.gameObject.SetActive(false);
		}

		//if (collision.gameObject.CompareTag("ICT1"))
		//{
		//	Panel1.gameObject.SetActive(false);
		//}

		if (other.tag=="ICT2")
		{
			Panel2.gameObject.SetActive(false);
		}

		if (other.tag=="ICT3")
		{
			Panel3.gameObject.SetActive(false);
		}

		if (other.tag=="ICT4")
		{
			Panel4.gameObject.SetActive(false);
		}

		if (other.tag=="Aging1")
		{
			Panel5.gameObject.SetActive(false);
		}

		if (other.tag=="Aging2")
		{
			Panel6.gameObject.SetActive(false);
		}

		if (other.tag=="Watch")
		{
			WatchImage.gameObject.SetActive(false);
		}
	}
}
