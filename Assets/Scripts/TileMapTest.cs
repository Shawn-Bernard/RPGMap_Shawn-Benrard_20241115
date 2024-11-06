using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class TileMapTest : MonoBehaviour
{
    public Camera MyCam;
    public Tilemap MyTileMap;
    public Tile TopMap;
    public Vector3Int TopMapPos = new Vector3Int(-2,1,-10);
    public int x;
    public int y;
    public int z;
    //public char[,] MDM;
    // Start is called before the first frame update
    void Start()
    {
        MyCam = Camera.main;
        TryGetComponent<Tilemap>(out MyTileMap);
        //MyTileMap.SetTile(new Vector3Int(0, 0, 0), TopMap);//print tile at (0,0,0)
        x = -19;
        y = 9;

        for (int i = 0; i < 37; i++)
        {

            MyTileMap.SetTile(new Vector3Int(x, y, 0), TopMap);
            x++;
        }

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        Vector3 mouseWorldPosition = MyCam.ScreenToWorldPoint(Input.mousePosition);
        GUI.Label(new Rect(50, 50, 600, 30), $"Mouse: {mouseWorldPosition} in cell space; {MyTileMap.WorldToCell(Input.mousePosition)}");
    }
}
