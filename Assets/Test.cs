using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System.IO;
using UnityEditor.U2D.Aseprite;

public class Test : MonoBehaviour
{
    public Tilemap MyTileMap;

    public TileBase groundTile;
    public TileBase wallTile;
    int Width;
    int Height;


    // Start is called before the first frame update
    void Start()
    {
        


        TryGetComponent<Tilemap>(out MyTileMap);
        //LoadPremadeMap($"{Application.dataPath}/Level.txt");
        LoadPremadeMap($"{Application.dataPath}/Level.txt");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    
    
    string MapString(int Width, int Height)
    {
        
        char[,] Map = new char[Width, Height];
        Debug.Log(Width);
        Debug.Log(Height);
        string tile = " ";

        for (int x = 0; x < Map.GetLength(0); x++)
        {
            for (int y = 0; y < Map.GetLength(1); y++)
            {

                if (Map[x, y] == '#')
                {
                    tile = "#";
                }
                else if (Map[x, y] == ' ')
                {
                    tile = " ";
                }
            }
        }
        
        return tile;
    }
    
    void ConvertMapToTilemap(string mapData)
    {
        for (int x = 0; x < mapData[0]; x++)
        {

            for (int y = 0; y < mapData[0] -1; y++)
            {
                if (mapData == "#")
                {
                    //Debug.Log("Ive placed a wall");
                    MyTileMap.SetTile(new Vector3Int(x, y, 0), wallTile);
                }
                else if (mapData == " ")
                {
                    //Debug.Log("Ive placed a ground");
                    MyTileMap.SetTile(new Vector3Int(x, y, 0), groundTile);
                }
            }
        }
        


    }

    void LoadPremadeMap(string Path)
    {
        
        string[] lines = File.ReadAllLines(Path);
        Width = lines[0].Length;
        Height = lines.Length;
        string mapData = MapString(Width, Height);
        ConvertMapToTilemap(mapData);

    }
    

}


