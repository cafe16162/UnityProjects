using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DrawLine : MonoBehaviour
{
	[SerializeField]
	LineRenderer lineRenderer;

	[SerializeField]
	bool isActive = true;
	public bool IsActive{ set{ isActive = value; } get{ return isActive; } }

	int vc = 0;		// Vertex Counts
	enum DrawState
	{
		idle,
		drawing,
	};
	DrawState state;

	void Start()
	{
		state = DrawState.idle;
		vc = 0;
		lineRenderer.SetVertexCount(vc);
		lineRenderer.useWorldSpace = true;
	}
	/*
	void Update()
	{
		if (!isActive) return;

		if (Input.GetMouseButtonDown(0))
		{
			state = DrawState.drawing;
			lineRenderer.SetVertexCount(++vc);
			lineRenderer.SetPosition(vc-1, Camera.main.ScreenToWorldPoint(Input.mousePosition));
		}
		else if (Input.GetMouseButton(0) && state == DrawState.drawing)
		{
			// itteinonagasaijounara
		}
	}
	*/
}
