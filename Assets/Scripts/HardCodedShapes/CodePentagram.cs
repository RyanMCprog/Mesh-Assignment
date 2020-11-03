using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodePentagram : MonoBehaviour
{
    private Mesh customMesh;
    // Start is called before the first frame update
    void Start()
    {
        var mesh = new Mesh();
        //Verts for penta
        var verts = new Vector3[5];

        verts[0] = new Vector3(0, 0, 0);
        verts[1] = new Vector3(0.5f, 1, 0);
        verts[2] = new Vector3(1, 0, 0);
        verts[3] = new Vector3(-0.5f, 0.5f, 0);
        verts[4] = new Vector3(1.5f, 0.5f, 0);
        mesh.vertices = verts;
        //indices for penta needs 9
        var indices = new int[9];

        indices[0] = 0;
        indices[1] = 1;
        indices[2] = 2;

        indices[3] = 0;
        indices[4] = 3;
        indices[5] = 1;

        indices[6] = 2;
        indices[7] = 1;
        indices[8] = 4;
        mesh.triangles = indices;
        //normals for penta
        var norms = new Vector3[5];

        norms[0] = -Vector3.forward;
        norms[1] = -Vector3.forward;
        norms[2] = -Vector3.forward;
        norms[3] = -Vector3.forward;
        norms[4] = -Vector3.forward;
        mesh.normals = norms;
        //uvs for penta
        var UVs = new Vector2[5];
        //here
        UVs[0] = new Vector2(0, 0);
        UVs[1] = new Vector2(0.5f, 1);
        UVs[2] = new Vector2(1, 0);
        UVs[3] = new Vector2(-0.5f, 0.5f);
        UVs[4] = new Vector2(1.5f,0.5f);
        mesh.uv = UVs;

        var filter = GetComponent<MeshFilter>();
        filter.mesh = mesh;
        customMesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDestroy()
    {
        if (customMesh != null)
        {
            Destroy(customMesh);
        }
    }
}
