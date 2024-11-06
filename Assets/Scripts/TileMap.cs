using JetBrains.Annotations;
using System;
using UnityEngine;
using Unity.Mathematics;
using UnityEngine.Tilemaps;


public class TileMap : MonoBehaviour
{
    public Camera MyCam;

    public Tilemap MyTileMap;

    

    public Tile Ground;
    public Tile Wall;
    
    int x ;
    int y ;

    public int[,] Map = new int[20, 20];
    

    int rand;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        rand = UnityEngine.Random.RandomRange(0, 2);
        MyCam = Camera.main;
        TryGetComponent<Tilemap>(out MyTileMap);
        //MyTileMap.SetTile(new Vector3Int(30, 30, 0), Wall);

        for (int y = 0; y < Map.GetLength(1); y++)
        {
            for (int x = 0; x < Map.GetLength(0); x++)
            {
               
                
               
                //Map[x, y] = rand;
                
            }
        }

        map();
    }
    
    void rule()
    {
        for (int y = 0; y < Map.GetLength(1); y++)
        {
            for (int x = 0; x < Map.GetLength(0); x++)
            {
                int count = neighgbours(x, y);
            }
        }
    }

    void map()
    {
        for (int y = 0; y < Map.GetLength(1); y++)
        {
            for (int x = 0; x < Map.GetLength(0); x++)
            {
                if (Map[x,y] == 1)
                {
                    MyTileMap.SetTile(new Vector3Int(x, y, 0), Wall);
                }
                else
                {
                    MyTileMap.SetTile(new Vector3Int(x, y, 0), Ground);
                }
                

            }
        }
    }

    public int neighgbours(int x, int y)
    {
        count = 0;
        for (int check_x = -1; check_x < Map.GetLength(0); check_x++)
        {
            for (int check_y = -1; check_y < Map.GetLength(1); check_y++)
            {
                if (Map[x,y] == 1)
                {

                }
            }
        }
        return count;
    }


    private void OnGUI()
    {
        Vector3 mouseWorldPosition = MyCam.ScreenToWorldPoint(Input.mousePosition);
        GUI.Label(new Rect(50, 50, 600, 30), $"Mouse: {mouseWorldPosition} in cell space; {MyTileMap.WorldToCell(Input.mousePosition)}");
    }
}
