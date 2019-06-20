using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
	public float turnSpeed = 100.0f;



	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime);

        if(Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);
	}
}
