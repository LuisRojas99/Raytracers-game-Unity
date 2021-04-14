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
        RaycastHit hit;
        if (Physics.Raycast(Target.transform.position, Target.transform.up, out hit,100)) {
            if (hit.rigidbody != null){
                vertices = new Vector3[] { Target.transform.position, new Vector3(Target.transform.position.x, Target.transform.position.y + 10, 0), new Vector3(Target.transform.position.x + 10, Target.transform.position.y, 0) };
                triangles = new int[] { 0, 1, 2 };
            }
        }
        
        
    
    }
    // Update is called once per frame

    void Update()
    {
        mesh.Clear();
        RaycastHit hit;
        if (Physics.Raycast(Target.transform.position, Target.transform.up, out hit,100))
        {
            if (hit.rigidbody != null)
            {
                vertices = new Vector3[] {Target.transform.position,  Target.transform.position, new Vector3(Target.transform.position.x, Target.transform.position.y + 10, 0), new Vector3(Target.transform.position.x + 10, Target.transform.position.y, 0) };
                triangles = new int[] { 0, 1, 2 };
                mesh.vertices = vertices;
                mesh.triangles = triangles;
            }
        }
        
    }
}
