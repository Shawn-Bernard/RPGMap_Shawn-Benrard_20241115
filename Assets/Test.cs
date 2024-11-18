using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System.IO;

public class Test : MonoBehaviour
{
    public Tilemap MyTileMap;

    public TileBase groundTile;
    public TileBase wallTile;
    char Wall = '#';
    string Walls;
    char Ground = ' ';
    char[,] Map = new char[0, 0];
    int Width;
    int Height;
    int x;
    int y;
    string[] lines = File.ReadAllLines($"{Application.dataPath}/Level.txt");


    // Start is called before the first frame update
    void Start()
    {
        


        TryGetComponent<Tilemap>(out MyTileMap);
        ConvertMapToTilemap(lines);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void ConvertMapToTilemap(string [] mapdata)
    {
        char[,] Map = new char[Width, Height];
        for (int x = 0; x < mapdata.Length; x++)
        {
            
            Width =+x;
            for (int y = 0; y < mapdata.Length; y++)
            {
                
                if (y == 0)
                {
                    Height++;
                }
                mapdata.GetValue(mapdata.Length);
                Map[x,y] = mapdata[x][y];
            }

        }

        MapString(Width, Height);
    }
    
    
    void MapString(int Width, int Height)
    {
        
        char[,] Map = new char[Width, Height];
        Debug.Log($"{Map.GetValue(x, y)}");
        Debug.Log($"W {Width} H {Height}");
        for (int x = 0; x < Map.GetLength(0); x++)
        {
            for (int y = 0; y < Map.GetLength(1); y++)
            {

                if (Map[x, y] == 1)
                {
                    MyTileMap.SetTile(new Vector3Int(x, y, 0), wallTile); 
                }
                else if (Map[x, y] == 0)
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

    void LoadPremadeMap(string Path)
    {
        string[] mapData = File.ReadAllLines($"{Application.dataPath}/Level.txt");

        ConvertMapToTilemap(mapData);
        
    }
    

}


