using UnityEngine;
using System.Collections;

using UnityEngine;
using System.Collections;

public class OscHeight : MonoBehaviour  
{
	void Update()
	{
		float rotationSpeed = 1;
		transform.RotateAroundLocal(Vector3.up, Time.deltaTime * rotationSpeed);
	}

}