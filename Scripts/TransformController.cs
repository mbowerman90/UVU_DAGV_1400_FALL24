using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        var x = Mathf.PingPong(Time.time,8);
        var p = new Vector3(x,0,0);
        transform.position = p;
        
        transform.Rotate(new Vector3(0,300,0) * Time.deltaTime);
    }
}
