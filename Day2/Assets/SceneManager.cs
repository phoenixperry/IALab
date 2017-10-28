using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {
    public GameObject plane;
    Mesh mesh;
    List<Vector3> verts = new List<Vector3>();
   public float jitterRange = 0.10f;
    //public bool isJitter = true; 
	// Use this for initialization
	void Start () {

        //how to find a game object 
        mesh = GameObject.Find("Plane").GetComponent<MeshFilter>().mesh; 
     
        Debug.Log("This mesh has " + mesh.vertexCount + " vertices");
      //  UpdateVerts(); 

	}
	
	// Update is called once per frame
	void Update () {
        UpdateVerts(); 
	}

    void UpdateVerts() {
        verts.Clear(); 
        for(int i =0; i<mesh.vertexCount; i++)
        {
            int col = i *11; //number of verties by col 
          
            Vector3 newPos = mesh.vertices[i];
            //  newPos.y += Random.Range(-jitterRange, jitterRange);
            // newPos.y = newPos.y - newPos.y * .8f; //think this through 1/2 way there
            // newPos.y = 0.2f * Mathf.Sin(i); //this way your sin goes by the grid form
            Debug.Log(Time.frameCount); 
            newPos.y = 0.4f * Mathf.Cos(col*Time.frameCount*0.0002f); // slow wave by cols
            //if (isJitter)
            //{
            //    newPos.y += Random.Range(-.02f, .02f ); 
            //} 
            verts.Add(newPos); 
        }
        mesh.SetVertices(verts);
        mesh.RecalculateNormals(); 
    
    } 
}
