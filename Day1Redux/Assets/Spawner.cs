using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject cubePre;
    int numCubes = 10;
    float totalDistance = 10; 
   
    void MakeCubes() {
        for (int i = 0; i < numCubes; i++)
        {
            float perc = i / (float)numCubes;
            float sin = Mathf.Sin(perc * (Mathf.PI / 2));
           
 float x = Mathf.Clamp((1.0f + sin * totalDistance), 0.0f, max: 4.0f); 

           // Debug.Log(perc * (Mathf.PI / 2)); 
            Vector3 pos = new Vector3(x, 5.0f, 0.0f);
            GameObject g = Instantiate(cubePre, pos, Quaternion.identity) as GameObject;
            g.GetComponent<CubeRotater>().RotateSpeed = perc * 0.8f;
            g.GetComponent<CubeRotater>().SetSize((1.0f - perc) * .7f);    
        }
    } 
	// Use this for initialization
	void Start () {
   
        MakeCubes(); 
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Space))
        { MakeCubes(); }
    }
}
