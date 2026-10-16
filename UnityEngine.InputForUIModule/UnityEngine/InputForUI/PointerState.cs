namespace UnityEngine.InputForUI;

internal struct PointerState
{
	private static readonly DiscreteTime kClickDelay; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Button <LastPressedButton>k__BackingField; //Field offset: 0x0
	private ButtonsState _buttonsState; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DiscreteTime <NextPressTime>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <ClickCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <LastPosition>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <LastDisplayIndex>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <LastPositionValid>k__BackingField; //Field offset: 0x20

	public ButtonsState ButtonsState
	{
		 get { } //Length: 11
	}

	public private int ClickCount
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private int LastDisplayIndex
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private Vector2 LastPosition
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 39
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public bool LastPositionValid
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public private Button LastPressedButton
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 10
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private DiscreteTime NextPressTime
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 20
	}

	private static PointerState() { }

	public ButtonsState get_ButtonsState() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_ClickCount() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_LastDisplayIndex() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector2 get_LastPosition() { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_LastPositionValid() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Button get_LastPressedButton() { }

	[CompilerGenerated]
	[IsReadOnly]
	public DiscreteTime get_NextPressTime() { }

	public void OnButtonChange(DiscreteTime currentTime, Button button, bool previousState, bool newState) { }

	public void OnButtonDown(DiscreteTime currentTime, Button button) { }

	public void OnButtonUp(DiscreteTime currentTime, Button button) { }

	public void OnMove(DiscreteTime currentTime, Vector2 position, int displayIndex) { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_ClickCount(int value) { }

	[CompilerGenerated]
	private void set_LastDisplayIndex(int value) { }

	[CompilerGenerated]
	private void set_LastPosition(Vector2 value) { }

	[CompilerGenerated]
	public void set_LastPositionValid(bool value) { }

	[CompilerGenerated]
	private void set_LastPressedButton(Button value) { }

	[CompilerGenerated]
	private void set_NextPressTime(DiscreteTime value) { }

}

