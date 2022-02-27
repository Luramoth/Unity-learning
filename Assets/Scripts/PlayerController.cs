using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	//VARIABLES
	public float vehicleSpeed = 20f;
	public float turnSpeed = 45f;

	private float vInput;
	private float hInput;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		// get horizontal input using the input class in unity which returns the variable going from 1 to 0 as a float variable
		hInput = Input.GetAxis("Horizontal");
		vInput = Input.GetAxis("Vertical");

		// Vertical movement
		transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed * vInput);
		// horizontal movement using rotation
		transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * hInput);
	}
}
