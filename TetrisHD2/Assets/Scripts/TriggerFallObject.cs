using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFallObject : MonoBehaviour
{

	Rigidbody2D rb;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name.Equals("PlayerWatermelon"))
			rb.isKinematic = false;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name.Equals("PlayerWatermelon"))
			Debug.Log("Got you!");
	}

}
