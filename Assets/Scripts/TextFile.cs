using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFile : MonoBehaviour
{
    public char[,] MDA = new char[20, 20];
    // Start is called before the first frame update
    void Start()
    {
       string Path =  $"{Application.dataPath}/TextFile/Text";
       string[] lines = System.IO.File.ReadAllLines(Path);
        int count = 0;
        for (int y = 0; y < lines.Length; y++)
        {
            string lines = lines[y];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
