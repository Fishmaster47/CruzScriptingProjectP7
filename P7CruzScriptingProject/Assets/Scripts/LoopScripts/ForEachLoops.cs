using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] strings = new string[3];
        strings[0] = "first string, yo!";
        strings[1] = "second string, yo!";
        strings[2] = "third string, yo!";

        foreach (string item in strings)
        {
            print(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
