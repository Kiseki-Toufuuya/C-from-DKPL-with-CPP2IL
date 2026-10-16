namespace Heqet;

public class ScrollRectEx : ScrollRect
{
	[CompilerGenerated]
	private Action <OnBeginDragCallback>k__BackingField; //Field offset: 0xF4
	[CompilerGenerated]
	private Action<Vector2> <OnDragCallback>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private Action <OnEndDragCallback>k__BackingField; //Field offset: 0xFC
	[CompilerGenerated]
	private Action<Single> <OnWheelScrollCallback>k__BackingField; //Field offset: 0x100

	public private Action OnBeginDragCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action<Vector2> OnDragCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnEndDragCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action<Single> OnWheelScrollCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ScrollRectEx() { }

	[CompilerGenerated]
	private Action get_OnBeginDragCallback() { }

	[CompilerGenerated]
	private Action<Vector2> get_OnDragCallback() { }

	[CompilerGenerated]
	private Action get_OnEndDragCallback() { }

	[CompilerGenerated]
	private Action<Single> get_OnWheelScrollCallback() { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	public virtual void OnDrag(PointerEventData eventData) { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	public virtual void OnScroll(PointerEventData eventData) { }

	[CompilerGenerated]
	public void set_OnBeginDragCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnDragCallback(Action<Vector2> value) { }

	[CompilerGenerated]
	public void set_OnEndDragCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnWheelScrollCallback(Action<Single> value) { }

}

