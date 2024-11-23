using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
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
    int playerX = 1;
    int playerY = 1;

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
    string GenerateMapString(int x, int y)
    {
        char[,] Words = new char[x,y];
        for (x = 0; x < Map.GetLength(0); x++)
        {
            for (y = 0; y < Map.GetLength(1); y++)
            {
                if (Map[x, y] == 1)
                {
                    MyTileMap.SetTile(new Vector3Int(x, y, 0), Wall);
                }
                else if (Map[x, y] == 0)
                {
                    MyTileMap.SetTile(new Vector3Int(x, y, 0), Ground);
                }
                else if (Map[x,y] == 2)
                {

                }
            }
        }
        return GenerateMapString(x, y);
    }
    void PlayerController()
    {
        
        MyTileMap.SetTile(new Vector3Int(playerX, playerY, 0), Player);
        if (Input.GetKeyDown(KeyCode.W) && Map[playerX, playerY + 1] != 1)
            //W pressed & checking above player is not equal to 1 
            {
            MyTileMap.SetTile(new Vector3Int(playerX, playerY, 0), Ground);
            //placing ground tile on player
            playerY++;
            //Moving playerY up one 
            MyTileMap.SetTile(new Vector3Int(playerX, playerY, 0), Player);
            //Placing player tile at new playerY 
            }
            else if (Input.GetKeyDown(KeyCode.A) && Map[playerX-1,playerY] != 1)
            {
            MyTileMap.SetTile(new Vector3Int(playerX, playerY, 0), Ground);
            playerX--;
            MyTileMap.SetTile(new Vector3Int(playerX, playerY, 0), Player);
            }
            else if (Input.GetKeyDown(KeyCode.S) && Map[playerX, playerY-1] != 1)
            {
            MyTileMap.SetTile(new Vector3Int(playerX, playerY, 0), Ground);
            playerY--;
            MyTileMap.SetTile(new Vector3Int(playerX, playerY, 0), Player);
            }
            else if (Input.GetKeyDown(KeyCode.D) && Map[playerX+1, playerY] != 1)
            {
            MyTileMap.SetTile(new Vector3Int(playerX, playerY, 0), Ground);
            playerX++;
            MyTileMap.SetTile(new Vector3Int(playerX, playerY, 0), Player);
            }
        
    }
    
}
