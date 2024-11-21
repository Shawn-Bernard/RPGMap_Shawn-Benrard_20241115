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

    string tile;
    

    int Width;
    int Height;


    // Start is called before the first frame update
    void Start()
    {


        TryGetComponent<Tilemap>(out MyTileMap);
        ConvertMapToTilemap($"{Application.dataPath}/Level.txt");
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
        char Wall = '#';
        char Ground = ' ';
        string tile = string.Empty;
        Debug.Log(Map.GetValue(Width));
        tile = string.Empty;
        if (Width == Wall)
        {

        }


    }
    void ConvertMapToTilemap(string mapData)
    {
        for (int x = 0; x < mapData.Length; x++)
        {
            for (int y = 0; y < mapData.Length; y++)
            {
                if (mapData.Length == '#')
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
                else if (mapData.Length == ' ')
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
        MapString(lines[0].Length, lines.Length);
        for (int x = 0; x < lines.Length; x++)
        {

            for (int y = 0; y < lines.Length; y++)
            {

                ConvertMapToTilemap(MapString(lines[0].Length, lines.Length));
            }
        }
    }

}


