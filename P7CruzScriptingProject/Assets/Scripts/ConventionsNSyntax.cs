using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsNSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position.x);


    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.x);

        if (transform.position.y >= 5f)
        {
            Debug.Log("im falling!");
        }
        else
        {
            Debug.Log("im NOT falling!");
        }
    }
}
