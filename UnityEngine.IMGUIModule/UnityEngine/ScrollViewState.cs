namespace UnityEngine;

internal class ScrollViewState
{
	public Rect position; //Field offset: 0x8
	public Rect visibleRect; //Field offset: 0x18
	public Rect viewRect; //Field offset: 0x28
	public Vector2 scrollPosition; //Field offset: 0x38
	public bool apply; //Field offset: 0x40
	public bool isDuringTouchScroll; //Field offset: 0x41
	public Vector2 touchScrollStartMousePosition; //Field offset: 0x44
	public Vector2 touchScrollStartPosition; //Field offset: 0x4C
	public Vector2 velocity; //Field offset: 0x54
	public float previousTimeSinceStartup; //Field offset: 0x5C

	[RequiredByNativeCode]
	public ScrollViewState() { }

}

