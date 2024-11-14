using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Text : MonoBehaviour
{
    RPGMap map;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.text = "test"; //map.GenerateMapString( 20, 20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
