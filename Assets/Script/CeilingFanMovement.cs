using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingFanMovement : MonoBehaviour
{
    float FanRotate = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,-(FanRotate * Time.deltaTime),0);
    }
}
