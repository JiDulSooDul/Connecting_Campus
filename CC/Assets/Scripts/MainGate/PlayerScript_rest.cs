using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript_rest : MonoBehaviour
{
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Move1"))
		{
			SceneManager.LoadScene(10);
		}
	}
}
