using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[ExecuteAlways]
public class DebugVertices : MonoBehaviour
{
    Vector3[] vertices;
    Mesh mesh;
    private void OnDrawGizmos()
    {
        if (vertices == null)
        { 
            mesh = GetComponent<MeshFilter>().sharedMesh;
            vertices = mesh.vertices;
        }

        foreach (var v in vertices) 
        {
            Vector3 viewVertValue = SceneView.GetAllSceneCameras()[0].WorldToViewportPoint(transform.position + v);
            string vert = "v: " + v.ToString();
            string wv = "wv: " + (transform.position + vert).ToString();
            string viewVert = "vv: " + viewVertValue.ToString();
            UnityEditor.Handles.Label(transform.position + v, vert + wv + viewVert);
        }
    }
}
