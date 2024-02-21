using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    float floatVariable;
    int integerVariable = 5;
    // Start is called before the first frame update
    void Start()
    {
        floatVariable = 1.5f;
        integerVariable = 11;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Float Variable; " + floatVariable);
        Debug.Log("Integer Variable; " + integerVariable);
    }
}
