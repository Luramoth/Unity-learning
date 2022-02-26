using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
//VARIABLES
	public float vehicleSpeed = 20f;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		// fuckface hoo ha-ha
		// jokes aside this is where we will have the vehicle start moving
		transform.Translate(Vector3.forward * Time.deltaTime * VehicleSpeed);
	}
}
