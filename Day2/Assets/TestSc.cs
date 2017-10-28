using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSc : MonoBehaviour {

    public GameObject obj;
    ArrayList objs; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        GameObject g = Instantiate(obj, Vector3.up, Quaternion.identity) as GameObject;

        //objs._________(g);
         
        g.transform.localScale = new Vector3(1.3f, 1.0f, 1.3f);

        Mesh meshie;
        g.GetComponent<MeshFilter>().mesh = meshie;

        //public List<Vector3> verts = new List<Vector3>();
        //verts._____(new Vector3(0,0,0));
        rigidbody 
    }

    public void SpawnObjects() {

    } 
}
