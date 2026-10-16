namespace UnityEngine.UIElements;

public class Clickable : PointerManipulator
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<EventBase> clickedWithEventInfo; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action clicked; //Field offset: 0x18
	private readonly long m_Delay; //Field offset: 0x20
	private readonly long m_Interval; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <active>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <lastMousePosition>k__BackingField; //Field offset: 0x34
	private int m_ActivePointerId; //Field offset: 0x3C
	private bool m_AcceptClicksIfDisabled; //Field offset: 0x40
	private IVisualElementScheduledItem m_Repeater; //Field offset: 0x44
	private IVisualElementScheduledItem m_PendingActivePseudoStateReset; //Field offset: 0x48

	public event Action clicked
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	public event Action<EventBase> clickedWithEventInfo
	{
		[CompilerGenerated]
		 add { } //Length: 125
		[CompilerGenerated]
		 remove { } //Length: 125
	}

	internal bool acceptClicksIfDisabled
	{
		internal get { } //Length: 11
		internal set { } //Length: 93
	}

	protected bool active
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	private InvokePolicy invokePolicy
	{
		private get { } //Length: 16
	}

	public private Vector2 lastMousePosition
	{
		[CompilerGenerated]
		 get { } //Length: 39
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public Clickable(Action handler) { }

	public Clickable(Action<EventBase> handler) { }

	public Clickable(Action handler, long delay, long interval) { }

	[CompilerGenerated]
	public void add_clicked(Action value) { }

	[CompilerGenerated]
	public void add_clickedWithEventInfo(Action<EventBase> value) { }

	private bool ContainsPointer(int pointerId) { }

	internal bool get_acceptClicksIfDisabled() { }

	[CompilerGenerated]
	protected bool get_active() { }

	private InvokePolicy get_invokePolicy() { }

	[CompilerGenerated]
	public Vector2 get_lastMousePosition() { }

	protected void Invoke(EventBase evt) { }

	private bool IsRepeatable() { }

	private void OnPointerCancel(PointerCancelEvent evt) { }

	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	protected void OnPointerDown(PointerDownEvent evt) { }

	protected void OnPointerMove(PointerMoveEvent evt) { }

	protected void OnPointerUp(PointerUpEvent evt) { }

	private void OnTimer(TimerState timerState) { }

	protected override void ProcessCancelEvent(EventBase evt, int pointerId) { }

	protected override void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	protected override void ProcessMoveEvent(EventBase evt, Vector2 localPosition) { }

	protected override void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	protected virtual void RegisterCallbacksOnTarget() { }

	[CompilerGenerated]
	public void remove_clicked(Action value) { }

	[CompilerGenerated]
	public void remove_clickedWithEventInfo(Action<EventBase> value) { }

	private void ResetActivePseudoState() { }

	internal void set_acceptClicksIfDisabled(bool value) { }

	[CompilerGenerated]
	protected void set_active(bool value) { }

	[CompilerGenerated]
	private void set_lastMousePosition(Vector2 value) { }

	internal void SimulateSingleClick(EventBase evt, int delayMs = 100) { }

	protected virtual void UnregisterCallbacksFromTarget() { }

}

