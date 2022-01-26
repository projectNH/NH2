using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
	public CharacterController characterController;
	public Transform cameraTransform;
	public float speed = 6.0f;

	public float gravity = -12.0f;
	public float jumpHeight = 3.0f;
	bool isGrounded;
	Vector3 force;

	public Transform groundCheck;
	public float groundDistance = 0.3f;
	public LayerMask groundMask;

	//public GameObject cameraAux;

	public float rotationSpeed = 500.0f;
	float turnSmoothVelocity;


	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		//jump
		isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

		if (isGrounded && force.y < 0)
		{
			force.y = -2f;
		}
		if (Input.GetButtonDown("Jump") && isGrounded)
		{
			force.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
		}

		//gravity
		force.y += gravity * Time.deltaTime;
		characterController.Move(force * Time.deltaTime);

		//rotation and movement
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector3 direction = new Vector3(horizontal, 0.0f, vertical);

		if (direction.magnitude >= 0.1f)
		{
			Vector3 cameraFoward = cameraTransform.forward;
			cameraFoward.y = 0.0f;
			cameraFoward = cameraFoward.normalized;

			Vector3 cameraRight = cameraTransform.right;
			cameraRight.y = 0.0f;
			cameraRight = cameraRight.normalized;

			//Vector3 moveDir = new Vector3 (thirdPersonCamera.transform.forward.z * horizontal, 0.0f, thirdPersonCamera.transform.right.x * vertical);
			Vector3 moveDir = cameraFoward * vertical + cameraRight * horizontal;

			//movement
			characterController.Move(moveDir.normalized * speed * Time.deltaTime);

			//facing foward
			transform.forward = moveDir.normalized;
		}

	}
}