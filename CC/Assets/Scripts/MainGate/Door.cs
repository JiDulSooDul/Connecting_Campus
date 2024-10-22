using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour
{
	public GameObject LG_Door_01;
	public GameObject LG_Door_02;
	public GameObject LG_Door_03;
	public GameObject LG_Door_04;
	public GameObject gate_l;
	public GameObject gate_r;
	public GameObject leg;
	public GameObject leg2;

	AudioSource _audioSource;
	public AudioClip OpenSound;
	public AudioClip CloseSound;

	void Start()
	{
		_audioSource = GetComponent<AudioSource>();
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag=="ICTDOOR")
		{
			LG_Door_01.gameObject.SetActive(false);
			LG_Door_02.gameObject.SetActive(false);
			leg.gameObject.SetActive(false);
			//AudioSource.PlayClipAtPoint(OpenSound, transform.position);
			_audioSource.clip = OpenSound;
			_audioSource.Play(0);
		}

		if (other.tag=="ICTDOOR2") 
		{
			LG_Door_03.gameObject.SetActive(false);
			LG_Door_04.gameObject.SetActive(false);
			//AudioSource.PlayClipAtPoint(OpenSound, transform.position);
			_audioSource.clip = OpenSound;
			_audioSource.Play(0);
		}

		if (other.tag=="AgingDoor")
		{
			gate_l.gameObject.SetActive(false);
			gate_r.gameObject.SetActive(false);
			leg2.gameObject.SetActive(false);
			//AudioSource.PlayClipAtPoint(OpenSound, transform.position);
			_audioSource.clip = OpenSound;
			_audioSource.Play(0);
		}

	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag=="ICTDOOR")
		{
			LG_Door_01.gameObject.SetActive(true);
			LG_Door_02.gameObject.SetActive(true);
			leg.gameObject.SetActive(true);
			//AudioSource.PlayClipAtPoint(CloseSound, transform.position);
			_audioSource.clip = CloseSound;
			_audioSource.Play(0);
		}

		if (other.tag=="ICTDOOR2")
        {
			LG_Door_03.gameObject.SetActive(true);
			LG_Door_04.gameObject.SetActive(true);
			//AudioSource.PlayClipAtPoint(CloseSound, transform.position);
			_audioSource.clip = CloseSound;
			_audioSource.Play(0);
		}

		if (other.tag=="AgingDoor")
		{
			gate_l.gameObject.SetActive(true);
			gate_r.gameObject.SetActive(true);
			leg2.gameObject.SetActive(true);
			//AudioSource.PlayClipAtPoint(CloseSound, transform.position);
			_audioSource.clip = CloseSound;
			_audioSource.Play(0);
		}

	}
}
