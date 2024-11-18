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
    char Wall = '#';
    char Ground = ' ';
    int Width;
    int Height;
    int x;
    int y;
    string[] lines = File.ReadAllLines($"{Application.dataPath}/Level.txt");


    // Start is called before the first frame update
    void Start()
    {
        


        TryGetComponent<Tilemap>(out MyTileMap);
        LoadPremadeMap($"{Application.dataPath}/Level.txt");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void ConvertMapToTilemap(string [] mapData)
    {

        MapString(Width, Height);
        char[,] Map = new char[Width, Height];

        Debug.Log($"{Map[Width, Height]}");
        for (int x = 0; x < Map.GetLength(0); x++)
        {
            for (int y = 0; y < Map.GetLength(1); y++)
            {

                if (Map[x, y] == Wall)
                {
                    MyTileMap.SetTile(new Vector3Int(x, y, 0), wallTile);
                }
                else if (Map[x, y] == Ground)
                {
                    MyTileMap.SetTile(new Vector3Int(x, y, 0), groundTile);
                }
            }
        }
        for (int x = 0; x < Map.GetLength(0); x++)
        {

            for (int y = 0; y < Map.GetLength(1); y++)
            {
                if (x == 0 || x == Map.GetLength(0) - 1 || y == 0 || y == Map.GetLength(1) - 1)
                //if x equal 0 or x equal map length(x) with a length of 16 -1 so I don't go out of array
                // and doing the same with y 
                {
                    Map[x, y] = Wall;// Set border tiles to walls
                                     //Debug.Log($"Wall at {x}, {y}");
                }
                else
                {
                    Map[x, y] = Ground;
                }
            }
        }

    }
    
    
    string MapString(int Width, int Height)
    {
        
        char[,] Map = new char[Width, Height];
        
        Debug.Log($"{Map[Width, Height]}");
        Debug.Log($"W {Width} H {Height}");
        for (int x = 0; x < Map.GetLength(0); x++)
        {
            for (int y = 0; y < Map.GetLength(1); y++)
            {

                if (Map[x, y] == Wall)
                {
                    MyTileMap.SetTile(new Vector3Int(x, y, 0), wallTile); 
                }
                else if (Map[x, y] == Ground)
                {
                    MyTileMap.SetTile(new Vector3Int(x, y, 0), groundTile);
                }
            }
        }
        for (int x = 0; x < Map.GetLength(0); x++)
        {

            for (int y = 0; y < Map.GetLength(1); y++)
            {
                if (x == 0 || x == Map.GetLength(0) - 1 || y == 0 || y == Map.GetLength(1) - 1)
                //if x equal 0 or x equal map length(x) with a length of 16 -1 so I don't go out of array
                // and doing the same with y 
                {
                    Map[x, y] = Wall;// Set border tiles to walls
                                     //Debug.Log($"Wall at {x}, {y}");
                }
                else
                {
                    Map[x, y] = Ground;
                }
            }
        }
        return MapString(Width, Height);
    }

    void LoadPremadeMap(string Path)
    {
        string[] mapData = File.ReadAllLines(Path);
        for (int x = 0; x < mapData.Length; x++)
        {

            Width = +x;
            for (int y = 0; y < mapData.Length; y++)
            {
                if (y == 0)
                {
                    Height++;
                }


            }

        }


        MapString(Width, Height);
        ConvertMapToTilemap(mapData);
        
    }
    

}


