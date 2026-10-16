namespace UnityEngine.InputSystem;

[DefaultMember("Item")]
[InputControlLayout(stateType = typeof(GamepadState), isGenericTypeOfDevice = True)]
public class Gamepad : InputDevice, IDualMotorRumble, IHaptics
{
	[CompilerGenerated]
	private static Gamepad <current>k__BackingField; //Field offset: 0x0
	private static int s_GamepadCount; //Field offset: 0x4
	private static Gamepad[] s_Gamepads; //Field offset: 0x8
	[CompilerGenerated]
	private ButtonControl <buttonWest>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private ButtonControl <buttonNorth>k__BackingField; //Field offset: 0x114
	[CompilerGenerated]
	private ButtonControl <buttonSouth>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private ButtonControl <buttonEast>k__BackingField; //Field offset: 0x11C
	[CompilerGenerated]
	private ButtonControl <leftStickButton>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private ButtonControl <rightStickButton>k__BackingField; //Field offset: 0x124
	[CompilerGenerated]
	private ButtonControl <startButton>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private ButtonControl <selectButton>k__BackingField; //Field offset: 0x12C
	[CompilerGenerated]
	private DpadControl <dpad>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private ButtonControl <leftShoulder>k__BackingField; //Field offset: 0x134
	[CompilerGenerated]
	private ButtonControl <rightShoulder>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private StickControl <leftStick>k__BackingField; //Field offset: 0x13C
	[CompilerGenerated]
	private StickControl <rightStick>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private ButtonControl <leftTrigger>k__BackingField; //Field offset: 0x144
	[CompilerGenerated]
	private ButtonControl <rightTrigger>k__BackingField; //Field offset: 0x148
	private DualMotorRumble m_Rumble; //Field offset: 0x14C

	public ButtonControl aButton
	{
		 get { } //Length: 14
	}

	public static ReadOnlyArray<Gamepad> all
	{
		 get { } //Length: 99
	}

	public ButtonControl bButton
	{
		 get { } //Length: 14
	}

	public ButtonControl buttonEast
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ButtonControl buttonNorth
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ButtonControl buttonSouth
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ButtonControl buttonWest
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ButtonControl circleButton
	{
		 get { } //Length: 14
	}

	public ButtonControl crossButton
	{
		 get { } //Length: 14
	}

	public private static Gamepad current
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public DpadControl dpad
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ButtonControl Item
	{
		 get { } //Length: 476
	}

	public ButtonControl leftShoulder
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public StickControl leftStick
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ButtonControl leftStickButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ButtonControl leftTrigger
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ButtonControl rightShoulder
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public StickControl rightStick
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ButtonControl rightStickButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ButtonControl rightTrigger
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ButtonControl selectButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ButtonControl squareButton
	{
		 get { } //Length: 14
	}

	public ButtonControl startButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ButtonControl triangleButton
	{
		 get { } //Length: 14
	}

	public ButtonControl xButton
	{
		 get { } //Length: 14
	}

	public ButtonControl yButton
	{
		 get { } //Length: 14
	}

	public Gamepad() { }

	protected virtual void FinishSetup() { }

	public ButtonControl get_aButton() { }

	public static ReadOnlyArray<Gamepad> get_all() { }

	public ButtonControl get_bButton() { }

	[CompilerGenerated]
	public ButtonControl get_buttonEast() { }

	[CompilerGenerated]
	public ButtonControl get_buttonNorth() { }

	[CompilerGenerated]
	public ButtonControl get_buttonSouth() { }

	[CompilerGenerated]
	public ButtonControl get_buttonWest() { }

	public ButtonControl get_circleButton() { }

	public ButtonControl get_crossButton() { }

	[CompilerGenerated]
	public static Gamepad get_current() { }

	[CompilerGenerated]
	public DpadControl get_dpad() { }

	public ButtonControl get_Item(GamepadButton button) { }

	[CompilerGenerated]
	public ButtonControl get_leftShoulder() { }

	[CompilerGenerated]
	public StickControl get_leftStick() { }

	[CompilerGenerated]
	public ButtonControl get_leftStickButton() { }

	[CompilerGenerated]
	public ButtonControl get_leftTrigger() { }

	[CompilerGenerated]
	public ButtonControl get_rightShoulder() { }

	[CompilerGenerated]
	public StickControl get_rightStick() { }

	[CompilerGenerated]
	public ButtonControl get_rightStickButton() { }

	[CompilerGenerated]
	public ButtonControl get_rightTrigger() { }

	[CompilerGenerated]
	public ButtonControl get_selectButton() { }

	public ButtonControl get_squareButton() { }

	[CompilerGenerated]
	public ButtonControl get_startButton() { }

	public ButtonControl get_triangleButton() { }

	public ButtonControl get_xButton() { }

	public ButtonControl get_yButton() { }

	public virtual void MakeCurrent() { }

	protected virtual void OnAdded() { }

	protected virtual void OnRemoved() { }

	public override void PauseHaptics() { }

	public override void ResetHaptics() { }

	public override void ResumeHaptics() { }

	[CompilerGenerated]
	protected void set_buttonEast(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_buttonNorth(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_buttonSouth(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_buttonWest(ButtonControl value) { }

	[CompilerGenerated]
	private static void set_current(Gamepad value) { }

	[CompilerGenerated]
	protected void set_dpad(DpadControl value) { }

	[CompilerGenerated]
	protected void set_leftShoulder(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_leftStick(StickControl value) { }

	[CompilerGenerated]
	protected void set_leftStickButton(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_leftTrigger(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_rightShoulder(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_rightStick(StickControl value) { }

	[CompilerGenerated]
	protected void set_rightStickButton(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_rightTrigger(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_selectButton(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_startButton(ButtonControl value) { }

	public override void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

}

