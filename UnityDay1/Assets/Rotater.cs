using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {
	public float RotateSpeed = 1.0f;

	Vector3 spinSpeed = new Vector3(0, 0, 0);
	Vector3 spinAxis = Vector3.up;

	void Start()
	{
		spinSpeed = new Vector3(Random.value, Random.value, Random.value);
        Debug.Log(Random.value); 
		spinAxis.x = .1f * (Random.value - Random.value);
	}

	public void SetSize(float size)
	{
		transform.localScale = new Vector3(size, size, size);
	}

	void Update()
	{
		transform.Rotate(spinSpeed);
        transform.RotateAround(Vector3.zero, spinAxis, RotateSpeed);
	}


}