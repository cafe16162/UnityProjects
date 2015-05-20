using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	[SerializeField]
	float speed = 5f;

	Vector2 dv;

	void Update()
	{
		dv.x = Input.GetAxis("Horizontal");
		dv.y = Input.GetAxis("Vertical");

		transform.Translate((Vector3)dv * Time.deltaTime * speed);
	}
}
