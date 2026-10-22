using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int myInt = 5;

    void Start()
    {

        Debug.Log(myInt);

        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt); 
    }

   // multiplybytwo
    int MultiplyByTwo(int number)
    {
        int result = number * 2;
        return result;
    }

    void Update()
    {
        // ok
    }
}
