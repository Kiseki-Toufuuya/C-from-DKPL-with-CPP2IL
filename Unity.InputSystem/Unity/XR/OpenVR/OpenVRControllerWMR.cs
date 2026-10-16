namespace Unity.XR.OpenVR;

[InputControlLayout(displayName = "Windows MR Controller (OpenVR)", commonUsages = new IL2CPP_TYPE_STRING[] {"LeftHand", "RightHand"}, hideInUI = True)]
public class OpenVRControllerWMR : XRController
{
	[CompilerGenerated]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x124
	[CompilerGenerated]
	private ButtonControl <touchpadClick>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private ButtonControl <touchpadTouch>k__BackingField; //Field offset: 0x12C
	[CompilerGenerated]
	private ButtonControl <gripPressed>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private ButtonControl <triggerPressed>k__BackingField; //Field offset: 0x134
	[CompilerGenerated]
	private ButtonControl <menu>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private AxisControl <trigger>k__BackingField; //Field offset: 0x13C
	[CompilerGenerated]
	private AxisControl <grip>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private Vector2Control <touchpad>k__BackingField; //Field offset: 0x144
	[CompilerGenerated]
	private Vector2Control <joystick>k__BackingField; //Field offset: 0x148

	[InputControl(noisy = True)]
	public Vector3Control deviceAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True)]
	public Vector3Control deviceVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl]
	public AxisControl grip
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl]
	public ButtonControl gripPressed
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"primary2DAxis"})]
	public Vector2Control joystick
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"primary"})]
	public ButtonControl menu
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"secondary2DAxis"})]
	public Vector2Control touchpad
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"primary2DAxisClick", "joystickOrPadPressed"})]
	public ButtonControl touchpadClick
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"primary2DAxisTouch", "joystickOrPadTouched"})]
	public ButtonControl touchpadTouch
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl]
	public AxisControl trigger
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl]
	public ButtonControl triggerPressed
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public OpenVRControllerWMR() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_deviceVelocity() { }

	[CompilerGenerated]
	public AxisControl get_grip() { }

	[CompilerGenerated]
	public ButtonControl get_gripPressed() { }

	[CompilerGenerated]
	public Vector2Control get_joystick() { }

	[CompilerGenerated]
	public ButtonControl get_menu() { }

	[CompilerGenerated]
	public Vector2Control get_touchpad() { }

	[CompilerGenerated]
	public ButtonControl get_touchpadClick() { }

	[CompilerGenerated]
	public ButtonControl get_touchpadTouch() { }

	[CompilerGenerated]
	public AxisControl get_trigger() { }

	[CompilerGenerated]
	public ButtonControl get_triggerPressed() { }

	[CompilerGenerated]
	protected void set_deviceAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_deviceVelocity(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_grip(AxisControl value) { }

	[CompilerGenerated]
	protected void set_gripPressed(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_joystick(Vector2Control value) { }

	[CompilerGenerated]
	protected void set_menu(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_touchpad(Vector2Control value) { }

	[CompilerGenerated]
	protected void set_touchpadClick(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_touchpadTouch(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_trigger(AxisControl value) { }

	[CompilerGenerated]
	protected void set_triggerPressed(ButtonControl value) { }

}

