using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
	private float speed = 3f;

	void Update()
	{
		rigidbody.velocity = Vector3.zero;
		
		if(Input.GetKey(KeyCode.W))
		{
			rigidbody.velocity = transform.forward * speed;
		}
		
		if(Input.GetKey(KeyCode.A))
		{
			rigidbody.velocity = -transform.right * speed;
		}
		
		if(Input.GetKey(KeyCode.S))
		{
			rigidbody.velocity = -transform.forward * speed;
		}
		
		if(Input.GetKey(KeyCode.D))
		{
			rigidbody.velocity = transform.right * speed;
		}
	}
}
