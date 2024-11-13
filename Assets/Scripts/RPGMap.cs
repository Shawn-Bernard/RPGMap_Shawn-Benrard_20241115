using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class RPGMap : MonoBehaviour
{
    public Tilemap MyTileMap;

    public TileBase Ground;
    public TileBase Wall;
    public TileBase Player;

    
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
                drawMap();
                


            }
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
        PlayerController();
    }


    void randRule()
    {
        for (int x = 0; x < Map.GetLength(0); x++)
        {

            for (int y = 0; y < Map.GetLength(1); y++)
            {
                
            }
        }
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
    void drawMap()
    {
        for (int x = 0; x < Map.GetLength(0); x++)
        {
            for (int y = 0; y < Map.GetLength(1); y++)
            {
                if (Map[x,y] == 1)
                {
                    MyTileMap.SetTile(new Vector3Int(x, y, 0), Wall);
                }
                else if (Map[x, y] == 0)
                {
                    MyTileMap.SetTile(new Vector3Int(x, y, 0), Ground);
                }
            }
        }
        ruleBorder();
    }
    string GenerateMapString(int Width, int Height)
    {
        return;
    }
    void PlayerController()
    {
        MyTileMap.SetTile(new Vector3Int(x, y, 0), Player);
        if (Input.GetKeyDown(KeyCode.W))
        {
            
            y++;
            MyTileMap.SetTile(new Vector3Int(x, y, 0), Player);
            MyTileMap.SetTile(new Vector3Int(x, y - 1, 0), Ground);
            
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            x--;
            MyTileMap.SetTile(new Vector3Int(x, y, 0), Player);
            MyTileMap.SetTile(new Vector3Int(x + 1, y, 0), Ground);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            y--;
            MyTileMap.SetTile(new Vector3Int(x, y, 0), Player);
            MyTileMap.SetTile(new Vector3Int(x, y + 1, 0), Ground);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            x++;
            MyTileMap.SetTile(new Vector3Int(x, y, 0), Player);
            MyTileMap.SetTile(new Vector3Int(x - 1, y, 0), Ground);
        }
    }
    
}
