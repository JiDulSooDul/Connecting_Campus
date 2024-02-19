using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMover : MonoBehaviour
{
	public static CharacterMover Instance;
	public float moveSpeed = 1.0f;
	public float rotationSpeed = 10.0f;

	private bool isActiveHint = true;
	private CharacterController m_CharacterController;
	private GameObject m_CanvasObj;
	private ActionController m_CurrentActionController;
	private Image hintImg;
	private Text hintText;
	private Vector2 m_Input;
	private Vector3 m_MoveDirection = Vector3.zero;

	void Awake()
	{
		Instance = this;
		Cursor.lockState = CursorLockMode.Confined;
		Cursor.visible = false;
	}

	// Use this for initialization
	void Start()
	{
		m_CharacterController = GetComponent<CharacterController>();
		m_CanvasObj = GameObject.Find("Canvas");

		hintImg = m_CanvasObj.transform.GetChild(0).GetComponent<Image>();
		hintText = m_CanvasObj.transform.GetChild(0).GetChild(0).GetComponent<Text>();

		ShowHint(false);
	}
	
	// Update is called once per frame
	void Update()
	{
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		m_Input = new Vector2 (horizontal, vertical);

		if (m_Input.sqrMagnitude > 1) {
			m_Input.Normalize ();
		}
			
		m_MoveDirection = new Vector3 (m_Input.x, 0, m_Input.y);
		m_MoveDirection = transform.TransformDirection (m_MoveDirection);

		m_CharacterController.Move (m_MoveDirection * Time.deltaTime * 2f);

		// for actions
		RaycastHit rHit;

		if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out rHit, 100.0f))
		{
			if(rHit.collider != null)
			{
				ActionController ac = rHit.collider.GetComponent<ActionController>();

				if(ac != null && Vector3.Distance(Camera.main.transform.position, ac.transform.position) <= ac.distance)
				{
					if(ac != m_CurrentActionController)
						m_CurrentActionController = ac;
				}
				else
					m_CurrentActionController = null;
			}
		}
		else
			m_CurrentActionController = null;

		if(m_CurrentActionController != null)
		{
			ShowHint(true);
			ActivateHint(!m_CurrentActionController.IsInAction);

			if(Input.GetKeyDown(KeyCode.E))
			{
				m_CurrentActionController.NextAction();
				ActivateHint(false);
			}
		}
		else
			ShowHint(false);
	}
		
	public void ActivateHint(bool activate)
	{
		if(isActiveHint == activate)
			return;

		isActiveHint = activate;

		Color c;

		if(activate)
		{
			c = hintImg.color;
			c.a *= 2;
			hintImg.color = c;

			c = hintText.color;
			c.a *= 2;
			hintText.color = c;
		}
		else
		{
			c = hintImg.color;
			c.a /= 2;
			hintImg.color = c;

			c = hintText.color;
			c.a /= 2;
			hintText.color = c;
		}
	}

	public void ShowHint(bool enable)
	{
		if(m_CanvasObj.activeSelf == enable)
			return;
		
		m_CanvasObj.SetActive(enable);
	}
}
