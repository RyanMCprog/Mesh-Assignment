using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeCube : MonoBehaviour
{
    private Mesh customMesh;
    // Start is called before the first frame update
    void Start()
    {
        var mesh = new Mesh();
        //Verts for cube
        var verts = new Vector3[24];
        //front
        verts[0] = new Vector3(0, 0, 0);
        verts[1] = new Vector3(0, 1, 0);
        verts[2] = new Vector3(1, 0, 0);
        verts[3] = new Vector3(1, 1, 0);
        //right
        verts[4] = new Vector3(1, 0, 0);
        verts[5] = new Vector3(1, 1, 0);
        verts[6] = new Vector3(1, 0, 1);
        verts[7] = new Vector3(1, 1, 1);
        //left
        verts[8] = new Vector3(0, 0, 0);
        verts[9] = new Vector3(0, 1, 0);
        verts[10] = new Vector3(0, 0, 1);
        verts[11] = new Vector3(0, 1, 1);
        //back
        verts[12] = new Vector3(0, 0, 1);
        verts[13] = new Vector3(0, 1, 1);
        verts[14] = new Vector3(1, 0, 1);
        verts[15] = new Vector3(1, 1, 1);
        //top
        verts[16] = new Vector3(0, 1, 0);
        verts[17] = new Vector3(0, 1, 1);
        verts[18] = new Vector3(1, 1, 0);
        verts[19] = new Vector3(1, 1, 1);
        //bottom
        verts[20] = new Vector3(0, 0, 0);
        verts[21] = new Vector3(0, 0, 1);
        verts[22] = new Vector3(1, 0, 0);
        verts[23] = new Vector3(1, 0, 1);
        mesh.vertices = verts;
        //indices for quad needs 6
        var indices = new int[36];
        //front
        indices[0] = 0;
        indices[1] = 1;
        indices[2] = 2;
        indices[3] = 1;
        indices[4] = 3;
        indices[5] = 2;

        //right
        indices[6] = 4;
        indices[7] = 5;
        indices[8] = 6;
        indices[9] = 5;
        indices[10] = 7;
        indices[11] = 6;

        //left
        indices[12] = 10;
        indices[13] = 11;
        indices[14] = 8;
        indices[15] = 11;
        indices[16] = 9;
        indices[17] = 8;

        //back
        indices[18] = 14;
        indices[19] = 15;
        indices[20] = 12;
        indices[21] = 15;
        indices[22] = 13;
        indices[23] = 12;

        //top
        indices[24] = 16;
        indices[25] = 17;
        indices[26] = 18;
        indices[27] = 17;
        indices[28] = 19;
        indices[29] = 18;

        //bottom
        indices[30] = 20;
        indices[31] = 21;
        indices[32] = 22;
        indices[33] = 21;
        indices[34] = 23;
        indices[35] = 22;
        mesh.triangles = indices;
        //normals for quad
        var norms = new Vector3[24];
        //front
        norms[0] = -Vector3.forward;
        norms[1] = -Vector3.forward;
        norms[2] = -Vector3.forward;
        norms[3] = -Vector3.forward;

        //right
        norms[4] = -Vector3.left;
        norms[5] = -Vector3.left;
        norms[6] = -Vector3.left;
        norms[7] = -Vector3.left;

        //left
        norms[8] = -Vector3.right;
        norms[9] = -Vector3.right;
        norms[10] = -Vector3.right;
        norms[11] = -Vector3.right;

        //back
        norms[12] = -Vector3.back;
        norms[13] = -Vector3.back;
        norms[14] = -Vector3.back;
        norms[15] = -Vector3.back;

        //top
        norms[16] = -Vector3.down;
        norms[17] = -Vector3.down;
        norms[18] = -Vector3.down;
        norms[19] = -Vector3.down;

        //bottom
        norms[20] = -Vector3.up;
        norms[21] = -Vector3.up;
        norms[22] = -Vector3.up;
        norms[23] = -Vector3.up;
        mesh.normals = norms;
        //uvs for quad
        var UVs = new Vector2[24];

        UVs[0] = new Vector2(0, 0);
        UVs[1] = new Vector2(0, 1);
        UVs[2] = new Vector2(1, 0);
        UVs[3] = new Vector2(1, 1);

        UVs[4] = new Vector2(0, 0);
        UVs[5] = new Vector2(0, 1);
        UVs[6] = new Vector2(1, 0);
        UVs[7] = new Vector2(1, 1);

        UVs[8] = new Vector2(0, 0);
        UVs[9] = new Vector2(0, 1);
        UVs[10] = new Vector2(1, 0);
        UVs[11] = new Vector2(1, 1);

        UVs[12] = new Vector2(0, 0);
        UVs[13] = new Vector2(0, 1);
        UVs[14] = new Vector2(1, 0);
        UVs[15] = new Vector2(1, 1);

        UVs[16] = new Vector2(0, 0);
        UVs[17] = new Vector2(0, 1);
        UVs[18] = new Vector2(1, 0);
        UVs[19] = new Vector2(1, 1);

        UVs[20] = new Vector2(0, 0);
        UVs[21] = new Vector2(0, 1);
        UVs[22] = new Vector2(1, 0);
        UVs[23] = new Vector2(1, 1);
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
