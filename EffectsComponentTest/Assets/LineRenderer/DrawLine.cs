using UnityEngine;
using System.Collections;

// 画面上をドラッグで線を描画
public class DrawLine : MonoBehaviour
{
	[SerializeField]
	LineRenderer lineRenderer;  // LineRendererコンポーネントをインスペクターからアタッチ

    [SerializeField]
    float minLength = 0.1f;     // セグメント長の下限値

	int vc = 0;		        // 頂点数(VertexCount)
    bool isDrawing;         // 描画中はtrue
    Vector2 prePos;         // 最後に記録された点
    Vector2 currentPos;     // 入力点
	
	void Start()
	{
        isDrawing = false;
		vc = 0;
		lineRenderer.SetVertexCount(vc);
		lineRenderer.useWorldSpace = true;  // ワールド座標で描画
	}
	
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
            vc = 0;
            prePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
			lineRenderer.SetVertexCount(vc+1);
			lineRenderer.SetPosition(vc++, prePos);
            isDrawing = true;
		}
		else if (Input.GetMouseButton(0) && isDrawing)
		{
            currentPos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if ((currentPos - prePos).magnitude > minLength)
            {
                lineRenderer.SetVertexCount(vc + 1);
                lineRenderer.SetPosition(vc++, currentPos);
                prePos = currentPos;
            }
		}
        else if (Input.GetMouseButtonUp(0))
        {
            isDrawing = false;
        }
	}
	
}
