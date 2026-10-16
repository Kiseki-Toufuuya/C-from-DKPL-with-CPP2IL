namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Pointer (1))]
public abstract class MouseEventBase : EventBase<T>, IMouseEvent, IMouseEventInternal, IPointerOrMouseEvent
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <mousePosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <localMousePosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <mouseDelta>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <clickCount>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <button>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <pressedButtons>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; //Field offset: 0x0

	public override int button
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public override int clickCount
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public override bool commandKey
	{
		 get { } //Length: 15
	}

	public override bool ctrlKey
	{
		 get { } //Length: 15
	}

	public internal virtual IEventHandler currentTarget
	{
		 get { } //Length: 31
		internal set { } //Length: 266
	}

	public internal override Vector2 localMousePosition
	{
		[CompilerGenerated]
		 get { } //Length: 39
		[CompilerGenerated]
		internal set { } //Length: 20
	}

	public override EventModifiers modifiers
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public override Vector2 mouseDelta
	{
		[CompilerGenerated]
		 get { } //Length: 39
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public override Vector2 mousePosition
	{
		[CompilerGenerated]
		 get { } //Length: 39
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public override int pressedButtons
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	private override IPointerEvent UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private override bool UnityEngine.UIElements.IMouseEventInternal.triggeredByOS
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private override int UnityEngine.UIElements.IPointerOrMouseEvent.pointerId
	{
		private get { } //Length: 61
	}

	private override Vector3 UnityEngine.UIElements.IPointerOrMouseEvent.position
	{
		private get { } //Length: 46
	}

	protected MouseEventBase`1() { }

	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[CompilerGenerated]
	public override int get_button() { }

	[CompilerGenerated]
	public override int get_clickCount() { }

	public override bool get_commandKey() { }

	public override bool get_ctrlKey() { }

	public virtual IEventHandler get_currentTarget() { }

	[CompilerGenerated]
	public override Vector2 get_localMousePosition() { }

	[CompilerGenerated]
	public override EventModifiers get_modifiers() { }

	[CompilerGenerated]
	public override Vector2 get_mouseDelta() { }

	[CompilerGenerated]
	public override Vector2 get_mousePosition() { }

	[CompilerGenerated]
	public override int get_pressedButtons() { }

	protected static T GetPooled(IPointerEvent pointerEvent) { }

	public static T GetPooled(IMouseEvent triggerEvent) { }

	internal static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition) { }

	public static T GetPooled(Event systemEvent) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	protected private virtual void PostDispatch(IPanel panel) { }

	protected private virtual void PreDispatch(IPanel panel) { }

	[CompilerGenerated]
	protected void set_button(int value) { }

	[CompilerGenerated]
	protected void set_clickCount(int value) { }

	internal virtual void set_currentTarget(IEventHandler value) { }

	[CompilerGenerated]
	internal void set_localMousePosition(Vector2 value) { }

	[CompilerGenerated]
	protected void set_modifiers(EventModifiers value) { }

	[CompilerGenerated]
	protected void set_mouseDelta(Vector2 value) { }

	[CompilerGenerated]
	protected void set_mousePosition(Vector2 value) { }

	[CompilerGenerated]
	protected void set_pressedButtons(int value) { }

	[CompilerGenerated]
	private override IPointerEvent UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent() { }

	[CompilerGenerated]
	private override bool UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS() { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(IPointerEvent value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(bool value) { }

	private override int UnityEngine.UIElements.IPointerOrMouseEvent.get_pointerId() { }

	private override Vector3 UnityEngine.UIElements.IPointerOrMouseEvent.get_position() { }

}

