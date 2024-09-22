using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherColorChange : MonoBehaviour
{
	public Color newColor = Color.red;

    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = newColor;
    }

}
