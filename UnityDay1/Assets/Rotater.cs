using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {
	public float RotateSpeed = 1.0f;

	public Vector3 spinSpeed = new Vector3(0, 0, 0);
	public Vector3 spinAxis = Vector3.down;

	void Start()
	{
        //how fast the cube itself is spinning 
        spinSpeed = new Vector3(Random.value, Random.value, Random.value);
     

        //this gives each cube a slightly different roation around axis 
		spinAxis.x = .1f * (Random.value - Random.value);

        //example of running the scale function to prove how it effects this 
        //SetSize(4.0f);
	}

	public void SetSize(float size)
	{
        //this allows us to randomly scale our cubes from the sketch object
		transform.localScale = new Vector3(size, size, size);
	}

	void Update()
	{
        //spin the cube itself 
        transform.Rotate(spinSpeed);
        //now spin the cube around an axis as well  
        transform.RotateAround(Vector3.zero, spinAxis, RotateSpeed);
	}


}