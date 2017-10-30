using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this is help code for Endless void 

public class CubeManager_ : MonoBehaviour {
    public GameObject[] cubies;
    // Use this for initialization
    int turn = 0; 
	void Start () {
       
        cubies = GameObject.FindGameObjectsWithTag("Cubie");
        //Debug.Log(cubies.Length); 
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            turn++;
            if (turn == 1) {
               GameObject g = GameObject.Find("one");
               GameObject g1 = GameObject.Find("two");
                Destroy(g);
                Destroy(g1);  
            }
            if (turn == 2)
            {
                GameObject g = GameObject.Find("three");
                GameObject g1 = GameObject.Find("four");
        

                if (cubies[1].name == "three")
                {
                    Debug.Log("last turn!");
                }
                Destroy(g);
                Destroy(g1);
            }
        }
	}
}
