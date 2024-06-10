using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public int width, height;
    public GameObject tilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        //GenerateGrid()
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #region
    public void GenerateGrid()
    {
        if (tilePrefab == null) 
        {
            Debug.LogError("No Tile");
            return;
        }

        for (int x = 0; x < width; x++) 
        {
            for (int y = 0; y < height; y++) 
            
            {
                Vector3 position = new Vector3(x, 0, y);
                GameObject newTile = Instantiate(tilePrefab,position,Quaternion.identity);
                newTile.transform.parent = transform;
                newTile.tag = "Tile";
            }
        }
    }
    #endregion
    public void ClearGrid() 
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        foreach (GameObject tile in tiles) 
        {
            DestroyImmediate(tile);
        }
    }

    public void AssignMaterial()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        Material material = Resources.Load < Material>("Tile");
        foreach (GameObject tile in tiles) 
        {
            tile.GetComponent<Renderer>().material = material;
        }
    }
}
