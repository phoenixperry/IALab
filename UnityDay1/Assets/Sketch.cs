using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {
	public GameObject myPrefab; 
	public int totalCubes = 8; 
	public int totalDistance = 6;
    GameObject newCube; 
	// Use this for initialization
	void Start () {

		for (int i = 0; i < totalCubes; i++) {
			float perc = i / (float)totalCubes; 
			float x = perc * totalDistance; 
			float y = 5.0f; 
			float z = 0.0f; 
			newCube = Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity) as GameObject; 
			newCube.GetComponent<Rotater> ().SetSize (1.0f - perc); 
			newCube.GetComponent<Rotater> ().RotateSpeed = 1.0f - perc;
       
		}
	}	
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			for (int i = 0; i < totalCubes; i++) {
				float perc = i / (float)totalCubes; 
				float x = perc * totalDistance; 
				float y = 5.0f; 
				float z = 0.0f; 
				GameObject newCube = Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity) as GameObject; 
				newCube.GetComponent<Rotater> ().SetSize (1.0f - perc); 
				newCube.GetComponent<Rotater> ().RotateSpeed = 1.0f - perc; 
			}
		}	
	}

}
