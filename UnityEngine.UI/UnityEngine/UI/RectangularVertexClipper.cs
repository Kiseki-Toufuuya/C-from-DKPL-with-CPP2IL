namespace UnityEngine.UI;

internal class RectangularVertexClipper
{
	private readonly Vector3[] m_WorldCorners; //Field offset: 0x8
	private readonly Vector3[] m_CanvasCorners; //Field offset: 0xC

	public RectangularVertexClipper() { }

	public Rect GetCanvasRect(RectTransform t, Canvas c) { }

}

