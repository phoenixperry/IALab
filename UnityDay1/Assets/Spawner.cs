using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject boxPrefab;
    public int numCubes = 10; 
    public float totalDistance = .4f; 

    // Use this for initialization
    public ArrayList boxes; 

	void Start () {
        boxes = new ArrayList();
        populator(); 
     

	}

    public void populator() {
        for (int i = 0; i < numCubes; i++)
        {
            float perc = i / (float)numCubes;
            float sin = Mathf.Sin(perc * (Mathf.PI / 2));
            float x = Mathf.Clamp((1.0f + sin * totalDistance), 0.0f, max: 4.0f);
            float y = 5.0f;
            float z = 0.0f;
            Vector3 pos = new Vector3(x, y, z);
            GameObject box = Instantiate(boxPrefab, pos, Quaternion.identity) as GameObject;
            boxPrefab.GetComponent<Rotater>().SetSize((1.0f - perc) * .7f);
            boxPrefab.GetComponent<Rotater>().RotateSpeed = perc * .8f;

        }
    } 
	// Update is called once per frame
	void Update () {
		
	}
}
