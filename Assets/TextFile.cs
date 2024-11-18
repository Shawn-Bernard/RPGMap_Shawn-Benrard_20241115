using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor.U2D.Aseprite;
using UnityEditor;
using System;

public class TextFile : MonoBehaviour
{

    private int Width;
    private int Height;
    char[] arr = { '#' };
    int wallcount;
    // Start is called before the first frame update
    void Start()
    {
        string Path = $"{Application.dataPath}/Level.txt";
        string[] lines = File.ReadAllLines(Path);

        //string[] map = new string[20, 20];
        
        
        for (int x = 0; x < lines.Length; x++)
        {
            
            for (int y = 0; y < lines.Length; y++)
            {
            }
        }
        thing(lines[0].Length,lines.Length);
        Debug.Log($"Width {Width}");
        Debug.Log($"Height {Height}");
        Debug.Log(thing(lines[0].Length, lines.Length));
    }

    string thing(int Width, int Height)
    {

        char[,] Map = new char[Width, Height];
        char[] tiles = { '#',' '};
        for (int x = 0; x < Map.GetLength(0); x++)
        {

            for (int y = 0; y < Map.GetLength(1); y++)
            {

            }
        }
        string mapdata = Map.ToString();
        return mapdata;

    }
    // Update is called once per frame
    void Update()
    {

    }
}

