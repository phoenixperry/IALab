using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeShower : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Time.fixedDeltaTime); 
	}
}
