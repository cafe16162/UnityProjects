using UnityEngine;
using System.Collections;

// trail.unity
// プレイヤーの移動
public class PlayerController : MonoBehaviour
{
	[SerializeField]
	float speed = 5f;   // 移動の速さ

	Vector2 dv;

	void Update()
	{
		dv.x = Input.GetAxis("Horizontal");
		dv.y = Input.GetAxis("Vertical");

		transform.Translate((Vector3)dv * Time.deltaTime * speed);
	}
}
