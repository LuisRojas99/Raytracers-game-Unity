/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleFan : MonoBehaviour
{


    Mesh mesh;
    public Transform Target;
    Vector3[] vertices;
    int[] triangles;
    Vector3[][][] MultipleVertexTriangles;
    // Start is called before the first frame update

    void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;

    }
    void MakeMeshData()
    {
        for (int i = 0; i < 360; i++)// Triangles
        {
            for (int j = 0; j < 3; j++)//vertex
            {
                //                            A                           B                    C
                //vertices = new Vector3[] { Target.transform.position, new Vector3(0, 1, 0), new Vector3(1, 0, 0) };

                if (j = 0)
                {
                    MultipleVertexTriangles[i][j][0] = Target.transform.position.x;
                    MultipleVertexTriangles[i][j][1] = Target.transform.position.y;
                    MultipleVertexTriangles[i][j][2] = Target.transform.position.z;// x    //z
                }
                else
                {
                    MultipleVertexTriangles[i][j][0] = Target.transform.position.x + i;
                    MultipleVertexTriangles[i][j][1] = Target.transform.position.y + i;
                    MultipleVertexTriangles[i][j][2] = Target.transform.position.z + i;
                }
            }
        }
    }
    void Start()
    {
        MakeMeshData();
    }

    public Vector3 facemouse()
    {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 direction = new Vector3(-mousePosition.x + transform.position.x, -mousePosition.y + transform.position.y,0);
        return direction;

    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 360; i++)// Triangles
        {
            for (int j = 0; j < 3; j++)//vertex
            {
                //                            A                           B                    C
                //vertices = new Vector3[] { Target.transform.position, new Vector3(0, 1, 0), new Vector3(1, 0, 0) };

                if (j = 0)
                {
                    MultipleVertexTriangles[i][j][0] = Target.transform.position.x;
                    MultipleVertexTriangles[i][j][1] = Target.transform.position.y;
                    MultipleVertexTriangles[i][j][2] = Target.transform.position.z;// x    //z
                }
                else {
                    MultipleVertexTriangles[i][j][0] = Target.transform.position.x + i;
                    MultipleVertexTriangles[i][j][1] = Target.transform.position.y + i;
                    MultipleVertexTriangles[i][j][2] = Target.transform.position.z + i;
                }
            }
        }
    }
}
*/