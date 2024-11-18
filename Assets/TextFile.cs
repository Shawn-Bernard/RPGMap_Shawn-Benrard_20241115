using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor.U2D.Aseprite;

public class TextFile : MonoBehaviour
{
    public char[,] Map = new char[20, 20];
    private int Width;
    private int Height;
    char wall = '#';
    // Start is called before the first frame update
    void Start()
    {
        string Path = $"{Application.dataPath}/Level.txt";
        string[] lines = File.ReadAllLines(Path);


        for (int x = 0; x < lines.Length; x++)
        {
            for (int y = 0; y < lines.Length; y++)
            {
                
                //if (x == lines.Length)
                //{
                //    Width++;
                //}
                //if (y == 0)
                //{
                //    Height++;
                //}
                
            }
        }

        for (int x = 0; x < lines.Length; x++)
        {
            Debug.Log(lines.GetValue(x));
            for (int y = 0; y < lines.Length; y++)
            {
                Width++;
                Height++;
                Debug.Log(lines.GetValue(y));
                Debug.Log(lines.GetValue(Width));
                Debug.Log(lines.GetValue(Height));
                lines.GetValue(x);
                Debug.Log(lines.GetValue(lines.GetLength(0)));



            }
        }
        Debug.Log($"Height {Height}");
        Debug.Log($"Width {Width}");
        Debug.Log($"{Map.Length}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

