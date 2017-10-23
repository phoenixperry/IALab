using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;  //lists don't come auto 
public class ProceduralMesh : MonoBehaviour {
    GameObject pyramid;
    public Material mat;


    public List<Vector3> verts = new List<Vector3>();
    public List<int> triPoints = new List<int>();
    public List<Vector2> uvs = new List<Vector2>(); 
    
	// Use this for initialization
	void Start () {
        pyramid = new GameObject();
        pyramid.AddComponent<MeshFilter>();
        pyramid.AddComponent<MeshRenderer>();
        pyramid.GetComponent<MeshRenderer>().material = mat;
        BuildPyramid();



    }

    // Update is called once per frame
    void Update () {
        pyramid.transform.Rotate(0, 1, 0); 
	}
    void BuildPyramid() {
        verts.Add(new Vector3(0,0,0));
        verts.Add(new Vector3(1, 2, 1));
        verts.Add(new Vector3(2, 0, 0));
        //face 1 

        //setting up the winding map 
        triPoints.Add(0);
        triPoints.Add(1);
        triPoints.Add(2);
//adding the mapping for the textures. The points map to what points  

        uvs.Add(new Vector2(0, 1));
        uvs.Add(new Vector2(0.5f, 0));
        uvs.Add(new Vector2(1, 1));

        //face 2 

        verts.Add(new Vector3(2, 0, 0));
        verts.Add(new Vector3(1, 2, 1));
        verts.Add(new Vector3(2, 0, 2));

        triPoints.Add(3);
        triPoints.Add(4);
        triPoints.Add(5);
      
        uvs.Add(new Vector2(0, 1));
        uvs.Add(new Vector2(0.5f, 0));
        uvs.Add(new Vector2(1, 1));


        //face 3 
        verts.Add(new Vector3(2, 0, 2));
        verts.Add(new Vector3(1, 2, 1));
        verts.Add(new Vector3(0, 0, 2));

        triPoints.Add(6);
        triPoints.Add(7);
        triPoints.Add(8);

        uvs.Add(new Vector2(0, 1));
        uvs.Add(new Vector2(0.5f, 0));
        uvs.Add(new Vector2(1, 1));

        //face 4 
        verts.Add(new Vector3(0, 0, 2));
        verts.Add(new Vector3(1, 2, 1));
        verts.Add(new Vector3(0, 0, 0));

        triPoints.Add(9);
        triPoints.Add(10);
        triPoints.Add(11);

        uvs.Add(new Vector2(0, 1));
        uvs.Add(new Vector2(0.5f, 0));
        uvs.Add(new Vector2(1, 1));

        for (int i = 0; i < verts.Count; i++) {
            Vector3 shift = verts[i];
            shift.x -= 1.0f;
            shift.z -= 1.0f;
        
            verts[i] = shift; 
        } 
        Mesh meshie = new Mesh();

        meshie.SetVertices(verts);
        meshie.triangles = triPoints.ToArray();
        meshie.uv = uvs.ToArray();

        pyramid.GetComponent<MeshFilter>().mesh = meshie;
        pyramid.transform.localScale = new Vector3(1.3f, 1.0f, 1.3f);
        pyramid.transform.Translate(0, 1, 0); 
    } 
}
