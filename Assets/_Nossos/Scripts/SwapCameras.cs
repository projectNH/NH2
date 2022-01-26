using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SwapCameras : MonoBehaviour
{
	[SerializeField]
	private GameObject fpsCamera;


	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(1))
		{
			if(fpsCamera.gameObject.activeInHierarchy)
			{
				fpsCamera.gameObject.SetActive(false);
				//to do: feedback sound
			}
			else
			{
				fpsCamera.gameObject.SetActive(true);
				//to do: feedback sound
			}
		}

			/*
			if (Input.GetMouseButtonDown(1))
			{

				aimVirtualCamera.gameObject.SetActive(true);

			}
			else if(Input.GetMouseButtonUp(1))
			{
				aimVirtualCamera.gameObject.SetActive(false);
			}
			*/
		}
}
