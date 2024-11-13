using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{
    public Tilemap MyTileMap;

    public Tile Player;
    int x = 5;
    int y = 5;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        MyTileMap.SetTile(new Vector3Int(x, y, 0), Player);
        if (Input.GetKeyDown(KeyCode.W))
        {
            y++;
            MyTileMap.SetTile(new Vector3Int(x, y, 0), Player);
            MyTileMap.SetTile(new Vector3Int(x , y-1, 0), null);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            x--;
            MyTileMap.SetTile(new Vector3Int(x, y, 0), Player);
            MyTileMap.SetTile(new Vector3Int(x +1, y, 0), null);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            y--;
            MyTileMap.SetTile(new Vector3Int(x, y, 0), Player);
            MyTileMap.SetTile(new Vector3Int(x , y+1, 0), null);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            x++;
            MyTileMap.SetTile(new Vector3Int(x, y, 0), Player);
            MyTileMap.SetTile(new Vector3Int(x -1, y, 0), null);
        }

    }
    
}
