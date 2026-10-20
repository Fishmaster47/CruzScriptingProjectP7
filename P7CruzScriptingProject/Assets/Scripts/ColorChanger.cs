using System.Collections;
using System.Collections.Generic;
using Unity.Android.Types;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            GetComponent<Renderer>().material.color = Color.magenta;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            GetComponent<Renderer>().material.color = Color.gray;
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            GetComponent<Renderer>().material.color = new Color(0.0f, 0.28f, 0.67f);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            GetComponent<Renderer>().material.color = new Color(0.0f, 0.5f, 0.0f);

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<Renderer>().material.color = new Color(0.6f, 0.3f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            GetComponent<Renderer>().material.color = new Color(0.5f, 0.0f, 1f);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            GetComponent<Renderer>().material.color = new Color(1.0f, 0.0f, 0.533f);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            GetComponent<Renderer>().material.color = new Color(0.6f, 0.6f, 1.0f);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Renderer>().material.color = Color.magenta;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            GetComponent<Renderer>().material.color = new Color(1.0f, 0.64f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            GetComponent<Renderer>().material.color = new Color(0.5f, 0f, 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Renderer>().material.color = new Color(0f, 0.5f, 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            GetComponent<Renderer>().material.color = new Color(0.5f, 1f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            GetComponent<Renderer>().material.color = new Color(0.5f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GetComponent<Renderer>().material.color = new Color(0f, 0f, 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            GetComponent<Renderer>().material.color = new Color(0.3f, 0f, 0.5f, 1f);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<Renderer>().material.color = new Color(0.7f, 0.7f, 0.7f);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            GetComponent<Renderer>().material.color = new Color(0.25f, 0.25f, 0.25f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GetComponent<Renderer>().material.color = new Color(1f, 0.5f, 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GetComponent<Renderer>().material.color = new Color(1f, 0.75f, 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GetComponent<Renderer>().material.color = new Color(1f, 1f, 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            GetComponent<Renderer>().material.color = new Color(0.5f, 1f, 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            GetComponent<Renderer>().material.color = new Color(0.5f, 1f, 1f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            GetComponent<Renderer>().material.color = new Color(0.5f, 0.65f, 1f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            GetComponent<Renderer>().material.color = new Color(0.65f, 0.5f, 1f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            GetComponent<Renderer>().material.color = new Color(0.8f, 0.5f, 1f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            GetComponent<Renderer>().material.color = new Color(1f, 0.5f, 1f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            GetComponent<Renderer>().material.color = new Color(1f, 0.5f, 0.7f);
        }
    }
}