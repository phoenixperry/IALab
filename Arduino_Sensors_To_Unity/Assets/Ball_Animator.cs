using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Animator : MonoBehaviour {
    int numBalls = 10;
    public GameObject sphere_shape; 
    ArrayList sphereGroup = new ArrayList();
      
	// Use this for initialization
	void Start () {
        for (int i = 0; i < numBalls; i++) {

            GameObject g = Instantiate(sphere_shape, new Vector3(i, 0.0f, 0.0f), Quaternion.identity) as GameObject;
            sphereGroup.Add(g);
            g.name = "sphere" + i; 
        }
      
    }
	

	void Update () {
        
        float prox = GameObject.Find("GameManager").GetComponent<SerialReader>().val;
        foreach (GameObject g in sphereGroup)
        {
      
            g.GetComponent<Rigidbody>().angularDrag = prox;
            g.transform.Translate(new Vector3( prox / numBalls*.02f, 0.0f, 0.0f));
        }
    }
}
