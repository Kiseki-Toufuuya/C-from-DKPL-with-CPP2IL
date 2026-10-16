namespace UnityEngine.XR.WindowsMR.Input;

[InputControlLayout(displayName = "Windows MR Controller", commonUsages = new IL2CPP_TYPE_STRING[] {"LeftHand", "RightHand"}, hideInUI = True)]
public class WMRSpatialController : XRControllerWithRumble
{
	[CompilerGenerated]
	private Vector2Control <joystick>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private Vector2Control <touchpad>k__BackingField; //Field offset: 0x124
	[CompilerGenerated]
	private AxisControl <grip>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private ButtonControl <gripPressed>k__BackingField; //Field offset: 0x12C
	[CompilerGenerated]
	private ButtonControl <menu>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private AxisControl <trigger>k__BackingField; //Field offset: 0x134
	[CompilerGenerated]
	private ButtonControl <triggerPressed>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private ButtonControl <joystickClicked>k__BackingField; //Field offset: 0x13C
	[CompilerGenerated]
	private ButtonControl <touchpadClicked>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private ButtonControl <touchpadTouched>k__BackingField; //Field offset: 0x144
	[CompilerGenerated]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x14C
	[CompilerGenerated]
	private AxisControl <batteryLevel>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private AxisControl <sourceLossRisk>k__BackingField; //Field offset: 0x154
	[CompilerGenerated]
	private Vector3Control <sourceLossMitigationDirection>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	private Vector3Control <pointerPosition>k__BackingField; //Field offset: 0x15C
	[CompilerGenerated]
	private QuaternionControl <pointerRotation>k__BackingField; //Field offset: 0x160

	[InputControl(noisy = True)]
	public AxisControl batteryLevel
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True, aliases = new IL2CPP_TYPE_STRING[] {"gripAngularVelocity"})]
	public Vector3Control deviceAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True, aliases = new IL2CPP_TYPE_STRING[] {"gripVelocity"})]
	public Vector3Control deviceVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"gripaxis"})]
	public AxisControl grip
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"gripbutton"})]
	public ButtonControl gripPressed
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"Primary2DAxis", "thumbstickaxes"})]
	public Vector2Control joystick
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"thumbstickpressed"})]
	public ButtonControl joystickClicked
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"Primary", "menubutton"})]
	public ButtonControl menu
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True)]
	public Vector3Control pointerPosition
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True, aliases = new IL2CPP_TYPE_STRING[] {"PointerOrientation"})]
	public QuaternionControl pointerRotation
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True)]
	public Vector3Control sourceLossMitigationDirection
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True)]
	public AxisControl sourceLossRisk
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"Secondary2DAxis", "touchpadaxes"})]
	public Vector2Control touchpad
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"joystickorpadpressed", "touchpadpressed"})]
	public ButtonControl touchpadClicked
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"joystickorpadtouched", "touchpadtouched"})]
	public ButtonControl touchpadTouched
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"triggeraxis"})]
	public AxisControl trigger
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"triggerbutton"})]
	public ButtonControl triggerPressed
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public WMRSpatialController() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public AxisControl get_batteryLevel() { }

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
	public ButtonControl get_joystickClicked() { }

	[CompilerGenerated]
	public ButtonControl get_menu() { }

	[CompilerGenerated]
	public Vector3Control get_pointerPosition() { }

	[CompilerGenerated]
	public QuaternionControl get_pointerRotation() { }

	[CompilerGenerated]
	public Vector3Control get_sourceLossMitigationDirection() { }

	[CompilerGenerated]
	public AxisControl get_sourceLossRisk() { }

	[CompilerGenerated]
	public Vector2Control get_touchpad() { }

	[CompilerGenerated]
	public ButtonControl get_touchpadClicked() { }

	[CompilerGenerated]
	public ButtonControl get_touchpadTouched() { }

	[CompilerGenerated]
	public AxisControl get_trigger() { }

	[CompilerGenerated]
	public ButtonControl get_triggerPressed() { }

	[CompilerGenerated]
	protected void set_batteryLevel(AxisControl value) { }

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
	protected void set_joystickClicked(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_menu(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_pointerPosition(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_pointerRotation(QuaternionControl value) { }

	[CompilerGenerated]
	protected void set_sourceLossMitigationDirection(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_sourceLossRisk(AxisControl value) { }

	[CompilerGenerated]
	protected void set_touchpad(Vector2Control value) { }

	[CompilerGenerated]
	protected void set_touchpadClicked(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_touchpadTouched(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_trigger(AxisControl value) { }

	[CompilerGenerated]
	protected void set_triggerPressed(ButtonControl value) { }

}

