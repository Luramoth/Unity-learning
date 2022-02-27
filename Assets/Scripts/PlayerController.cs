using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	//VARIABLES
	public float vehicleSpeed = 20f;
	public float turnSpeed;

	public float hInput;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		// get horizontal input usint he input class in unity which returns the variable going from 1 to 0 as a float variable
		hInput = Input.GetAxis("Horizontal");

		// fuckface hoo ha-ha
		// jokes aside this is where we will have the vehicle start moving
		transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed);
		transform.Translate(Vector3.right * Time.deltaTime* turnSpeed * hInput);
	}
}
