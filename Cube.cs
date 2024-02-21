using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    string firstVariable = "Gaming";
    string secondVariable = "is";
    string thirdVariable = "Life";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("First Variable: " + firstVariable);
        Debug.Log("Second Variable: " + secondVariable);
        Debug.Log("Third Variable: " + thirdVariable);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Combined Variables: " + firstVariable + "" + secondVariable + "" + thirdVariable);
    }
}
