namespace UnityEngine;

internal class SliderState
{
	public float dragStartPos; //Field offset: 0x8
	public float dragStartValue; //Field offset: 0xC
	public bool isDragging; //Field offset: 0x10

	[RequiredByNativeCode]
	public SliderState() { }

}

