namespace UnityEngine;

internal sealed class GUIScrollGroup : GUILayoutGroup
{
	public float calcMinWidth; //Field offset: 0x7C
	public float calcMaxWidth; //Field offset: 0x80
	public float calcMinHeight; //Field offset: 0x84
	public float calcMaxHeight; //Field offset: 0x88
	public float clientWidth; //Field offset: 0x8C
	public float clientHeight; //Field offset: 0x90
	public bool allowHorizontalScroll; //Field offset: 0x94
	public bool allowVerticalScroll; //Field offset: 0x95
	public bool needsHorizontalScrollbar; //Field offset: 0x96
	public bool needsVerticalScrollbar; //Field offset: 0x97
	public GUIStyle horizontalScrollbar; //Field offset: 0x98
	public GUIStyle verticalScrollbar; //Field offset: 0x9C

	[RequiredByNativeCode]
	public GUIScrollGroup() { }

	public virtual void CalcHeight() { }

	public virtual void CalcWidth() { }

	public virtual void SetHorizontal(float x, float width) { }

	public virtual void SetVertical(float y, float height) { }

}

