using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADS : MonoBehaviour
{
    public Vector3 aimDownSight;
    // x = -0.142 y = 0.105 z = -0.164
    public Vector3 hipFire;
    // x = 0.021 y = 0.052 z = -0.164
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButton(1)) 
        {
            transform.localPosition = Vector3.Slerp(transform.localPosition,aimDownSight, 10 * Time.deltaTime);
        }
        if(Input.GetMouseButtonUp(1))
        {
            transform.localPosition = hipFire;
        }
    }
}
