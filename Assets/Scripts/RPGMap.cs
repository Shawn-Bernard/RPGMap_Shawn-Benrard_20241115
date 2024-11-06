using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class RPGMap : MonoBehaviour
{
    public Tilemap MyTileMap;

    public Tile Ground;
    public Tile Wall;

    public int[,] Map = new int[15, 15];

    int x;
    int y;

    int rand;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        rand = UnityEngine.Random.RandomRange(0, 2);
        TryGetComponent<Tilemap>(out MyTileMap);
        //Map[x, y] = rand;
        for (int x = 0; x < Map.GetLength(0); x++)
        {
            for (int y = 0; y < Map.GetLength(1); y++)
            {

                DrawMap();
                

            }
        }
        
    }
    void rule()
    {
        for (int x = 0; x < Map.GetLength(0); x++)
        {
            for (int y = 0; y < Map.GetLength(1); y++)
            {
                if (Map[x,y] < 0 )
                {
                    MyTileMap.SetTile(new Vector3Int(x, y, 0), Wall);

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
                if (Map[x, y] == 1)
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

    int neighgbours(int x, int y)
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
    // Update is called once per frame
    void Update()
    {
        
    }
}
