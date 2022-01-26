using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRotation : MonoBehaviour
{
	public float rotationPower = 3f;
	public float rotationLerp = 0.5f;

	public GameObject cameraTarget;
	public Camera mainCamera;
	// Start is called before the first frame update
	void Start()
	{
		;
	}

	// Update is called once per frame
	void Update()
	{
		/*float newAngleY = Mathf.LerpAngle(cameraTarget.transform.rotation.y, mainCamera.transform.rotation.y, Time.deltaTime);
		float newAngleX = Mathf.LerpAngle(cameraTarget.transform.rotation.x, mainCamera.transform.rotation.x, Time.deltaTime);

		mainCamera.transform.eulerAngles = new Vector3(newAngleX, newAngleY, 0.0f);*/
	}
}
