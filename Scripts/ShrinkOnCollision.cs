using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkOnCollision : MonoBehaviour
{
   public float shrinkFactor = 0.8f;

	void OnCollisionEnter(Collision collision)
	{
		transform.localScale *= shrinkFactor;
	}

}
