using UnityEngine;
using System.Collections;

public enum RotationAxes
{
	MouseX = 0,
	MouseY = 1
}

public class MouseLook : MonoBehaviour
{
	public RotationAxes axes = RotationAxes.MouseX;
	public float sensitivityX = 15F;
	public float sensitivityY = 15F;
	
	public float minimumY = -60F;
	public float maximumY = 60F;

	float rotationY = 0F;
	float rotationX = 0F;

	void Start()
	{
		Cursor.lockState = CursorLockMode.Confined;
		Cursor.visible = false;
	}

	void Update ()
	{

		if (axes == RotationAxes.MouseX) {
			float _moveSpeed = Input.GetAxis ("Mouse X");

			rotationX = _moveSpeed  * sensitivityX * Time.deltaTime;
		} 
		else 
		{
			float _moveSpeed = Input.GetAxis ("Mouse Y");

			rotationY += _moveSpeed * sensitivityY * Time.deltaTime;
		}

		if (axes == RotationAxes.MouseX)
			transform.parent.Rotate (0, rotationX, 0);
		else 
		{
			rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
			
			transform.localEulerAngles = new Vector3 (-rotationY, transform.localEulerAngles.y, 0);
		}
	}
}