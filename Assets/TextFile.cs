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
        Width = lines.Length;
        Height = lines.Length;
        char[,] Map = new char[Width, Height];
        
        Debug.Log("Map " +Map.GetValue(Width));
        Debug.Log(lines.GetValue(0));

        for (int x = 0; x < lines.Length; x++)
        {
            //Map.SetValue(lines.GetValue(x), Map.Length);
            //lines.SetValue(lines.GetValue(x),Width);

            Map.SetValue(lines.GetValue(x), Width);
            Debug.Log("Map " + Map.GetValue(Width));

            for (int y = 0; y < lines.Length; y++)
            {

                //Debug.Log($"x{x}");
                //Debug.Log($"y{y}");
            }
        }
        Debug.Log($"Width {Width}");
        Debug.Log($"Width {Width}");
        Debug.Log($"Height {Height}");
        Debug.Log(wallcount);
        Debug.Log(lines.Length);
    }

    void thing(int Width, int Height)
    {

        char[,] Map = new char[Width, Height];
        char[] tiles = { '#',' '};
        for (int x = 0; x < Map.GetLength(0); x++)
        {

            for (int y = 0; y < Map.GetLength(1); y++)
            {

            }
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}

