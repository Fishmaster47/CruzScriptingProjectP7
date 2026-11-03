using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class IfThenStatements : MonoBehaviour
{
    float chocolateTemperature = 85.0f;
    float hotLimitTemperature = 70f;
    float coldLimitTemperature = 40f;

    // Start is called before the first frame update
    void Start()
    {
        TemperatureTest();
    }

    // Update is called once per frame
    void Update()
    {
        // starts the temperature test
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }

        // decrease temperature over time bro!
        chocolateTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        // checks chocolate temperature
        if (chocolateTemperature >= hotLimitTemperature)
        {
            Debug.Log("hot chocolate is too hot to drink, yo!");
        }
        else if (chocolateTemperature <= coldLimitTemperature)
        {
            Debug.Log("hot chocolate is too chilly, yo!");
        }
        else
        {
            Debug.Log("Hot chocolate is just right, yo!");
        }
    }
}