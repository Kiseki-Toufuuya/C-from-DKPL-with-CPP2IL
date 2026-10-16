namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(MouseState), isGenericTypeOfDevice = True)]
public class Mouse : Pointer, IInputStateCallbackReceiver
{
	[CompilerGenerated]
	private static Mouse <current>k__BackingField; //Field offset: 0x0
	internal static Mouse s_PlatformMouseDevice; //Field offset: 0x4
	[CompilerGenerated]
	private DeltaControl <scroll>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private ButtonControl <leftButton>k__BackingField; //Field offset: 0x12C
	[CompilerGenerated]
	private ButtonControl <middleButton>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private ButtonControl <rightButton>k__BackingField; //Field offset: 0x134
	[CompilerGenerated]
	private ButtonControl <backButton>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private ButtonControl <forwardButton>k__BackingField; //Field offset: 0x13C
	[CompilerGenerated]
	private IntegerControl <clickCount>k__BackingField; //Field offset: 0x140

	public ButtonControl backButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public IntegerControl clickCount
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private static Mouse current
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public ButtonControl forwardButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ButtonControl leftButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ButtonControl middleButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ButtonControl rightButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public DeltaControl scroll
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Mouse() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public ButtonControl get_backButton() { }

	[CompilerGenerated]
	public IntegerControl get_clickCount() { }

	[CompilerGenerated]
	public static Mouse get_current() { }

	[CompilerGenerated]
	public ButtonControl get_forwardButton() { }

	[CompilerGenerated]
	public ButtonControl get_leftButton() { }

	[CompilerGenerated]
	public ButtonControl get_middleButton() { }

	[CompilerGenerated]
	public ButtonControl get_rightButton() { }

	[CompilerGenerated]
	public DeltaControl get_scroll() { }

	public virtual void MakeCurrent() { }

	protected virtual void OnAdded() { }

	protected void OnNextUpdate() { }

	protected virtual void OnRemoved() { }

	protected void OnStateEvent(InputEventPtr eventPtr) { }

	[CompilerGenerated]
	protected void set_backButton(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_clickCount(IntegerControl value) { }

	[CompilerGenerated]
	private static void set_current(Mouse value) { }

	[CompilerGenerated]
	protected void set_forwardButton(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_leftButton(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_middleButton(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_rightButton(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_scroll(DeltaControl value) { }

	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	public void WarpCursorPosition(Vector2 position) { }

}

