using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    bool booleanVariable = false;
    // Start is called before the first frame update
    void Start()
    {
        booleanVariable = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Boolean Variable: '" + booleanVariable);
    }
}
