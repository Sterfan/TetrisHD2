using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformY : MonoBehaviour
{

	float dirX, moveSpeed = 3f;
	bool moveRight = true;

	// Update is called once per frame
	void Update()
	{
		if (transform.position.y > 4f)
			moveRight = false;
		if (transform.position.y < -4f)
			moveRight = true;

		if (moveRight)
			transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
		else
			transform.position = new Vector2(transform.position.x , transform.position.y - moveSpeed * Time.deltaTime);
	}
}
