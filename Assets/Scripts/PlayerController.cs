using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{
    public Tilemap MyTileMap;

    public TileBase Player;
    int x;
    int y;

    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent<Tilemap>(out MyTileMap);
        MyTileMap.SetTile(new Vector3Int(x, y, 0), Player);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Player  -1;
        }
        
    }
    
}
