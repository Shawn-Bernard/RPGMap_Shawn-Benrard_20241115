using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class RPGMap : MonoBehaviour
{
    public Tilemap MyTileMap;

    public TileBase Ground;
    public TileBase Wall;

    public GameObject Player;
    
    public int[,] Map = new int[20, 20];

    int x;
    int y;

    int rand;

    
    // Start is called before the first frame update
    void Start()
    {
        
        TryGetComponent<Tilemap>(out MyTileMap);
        //Map[x, y] = rand;
        for (int x = 0; x < Map.GetLength(0); x++)
        {
            for (int y = 0; y < Map.GetLength(1); y++)
            {
                DrawMap();
                ruleBorder();


            }
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    

    void Rule()
    {
        
    }
    void ruleBorder()
    {

        for (int x = 0; x < Map.GetLength(0); x++)
        {
            
            for (int y = 0; y < Map.GetLength(1); y++)
            {
                if (x == 0 || x == Map.GetLength(0) -1 || y == 0 || y == Map.GetLength(1)-1)
                 //if x equal 0 or x equal map length(x) with a length of 16 -1 so I don't go out of array
                 // and doing the same with y 
                {
                    Map[x, y] = 1;  // Set border tiles to walls
                    //Debug.Log($"Wall at {x}, {y}");
                }




            }
        }
    }
    void DrawMap()
    {
        for (int x = 0; x < Map.GetLength(0); x++)
        {
            for (int y = 0; y < Map.GetLength(1); y++)
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

    
    
}
