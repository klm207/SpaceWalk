using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Cal : MonoBehaviour
{

    string val;
    int temp;
    Rect text, button1, button2, button3, buttonPlus, buttonEqual;
    bool endOfCalc;
    void Start()
    {
        text = new Rect(10, 10, 200, 20);
        button1 = new Rect(10, 30, 20, 20);
        button2 = new Rect(30, 30, 20, 20);
        button3 = new Rect(50, 30, 20, 20);
        buttonPlus = new Rect(70, 30, 20, 20);
        buttonEqual = new Rect(90, 30, 20, 20);
        val = "";
        endOfCalc = false;
    }

    // Update is called once per frame
    void OnGUI()
    {
        GUI.TextField(text, val);
        if (GUI.Button(button1, "1"))
        {
            Calculation("1");
        }
        if (GUI.Button(button2, "2"))
        {
            Calculation("2");
        }
        if (GUI.Button(button3, "3"))
        {
            Calculation("3");
        }
        if (GUI.Button(buttonPlus, "+"))
        {
            temp += int.Parse(val);
            val = "";
        }
        if (GUI.Button(buttonEqual, "="))
        {
            temp += int.Parse(val);
            val = temp.ToString();
            endOfCalc = true;
        }
    }
    void Calculation(string str)
    {
        if (!endOfCalc)
            val += str;
        else
        {
            val = "";
            val += str;
            endOfCalc = false;
            temp = 0;
        }
    }
    // Use this for initialization
   
}

