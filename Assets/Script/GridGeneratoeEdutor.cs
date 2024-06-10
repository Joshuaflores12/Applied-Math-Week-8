using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Runtime.CompilerServices;

[CustomEditor(typeof(GridGenerator))]
public class GridGeneratoeEdutor : Editor
{
    // Start is called before the first frame update
    public override void OnInspectorGUI() 
    {
        DrawDefaultInspector();
        GridGenerator gridGenerator = (GridGenerator)target;
        if (GUILayout.Button("Generate Grid")) 
        {
            gridGenerator.GenerateGrid();
        }

        if (GUILayout.Button("Clear Grid")) 
        {
            gridGenerator.ClearGrid();
        }
        if (GUILayout.Button("Assign Material")) 
        {
            gridGenerator.AssignMaterial();
        }
    }

    [MenuItem("Tools/ Generate Grid")]

    public void GenerateGridMenu() 
    {
        GridGenerator gridGenerator = FindAnyObjectByType<GridGenerator>();
        if (gridGenerator != null)
        {
            gridGenerator.GenerateGrid();
        }
        else 
        {
            Debug.LogError("No Grid Generate Found");
        }
    }

    [MenuItem("Tools/ Clear Grid")]

    public void ClearGridMenu()
    {
        GridGenerator gridGenerator = FindAnyObjectByType<GridGenerator>();
        if (gridGenerator != null)
        {
            gridGenerator.ClearGrid();
        }
        else
        {
            Debug.LogError("No Grid Generate Found");
        }
    }

    [MenuItem("Tools/Assign Material")]

    public void AssignMaterial()
    {
        GridGenerator gridGenerator = FindAnyObjectByType<GridGenerator>();
        if (gridGenerator != null) 
        {
            gridGenerator.AssignMaterial();
        }

        else
        {
            Debug.LogError("No Grid Generator Found");
        }
    }
}
