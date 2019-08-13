using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public float X,Y,Z;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     transform.Rotate(new Vector3(X,Y,Z));   
    }
}
