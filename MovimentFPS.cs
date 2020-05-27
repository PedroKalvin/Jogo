using UnityEngine;
using System.Collections;
using System;

public class MovimentFPS : MonoBehaviour
{
	public CharacterController controller;
	
	public float velocidade = 12f;
	
	void Update()
	{
		float X = Input.GetAxis("Horizontal");
		float Z = Input.GetAxis("Vertical");
		
		Vector3 move = transform.right * X + transform.forward * Z;
		
		controller.Move(move * velocidade * Time.deltaTime);
	}
}