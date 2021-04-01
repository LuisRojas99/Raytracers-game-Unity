using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshFilter))]
public class ProceduralMesh : MonoBehaviour
{
    // Start is called before the first frame update
    Mesh mesh;
    public Transform Target;
    Vector3[] vertices;
    int[] triangles;
    
    void Awake() {
        mesh = GetComponent<MeshFilter>().mesh;
    
    }
    void Start()
    {
        MakeMeshData();
        
    }
    
    void MakeMeshData() {

        vertices = new Vector3[] { Target.transform.position, new Vector3(0,1,0), new Vector3(1,0,0)};
        triangles = new int[] { 0, 1, 2 };
    
    }
    // Update is called once per frame

    void Update()
    {
        mesh.Clear();
       
        vertices = new Vector3[] { Target.transform.position, new Vector3(0, 1, 0), new Vector3(1, 0, 0) };
        triangles = new int[] { 0, 1, 2 };
        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }
}
