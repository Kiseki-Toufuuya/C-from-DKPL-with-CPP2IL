namespace Unity.XR.Oculus.Input;

[InputControlLayout(displayName = "Oculus Touch Controller", commonUsages = new IL2CPP_TYPE_STRING[] {"LeftHand", "RightHand"}, hideInUI = True)]
public class OculusTouchController : XRControllerWithRumble
{
	[CompilerGenerated]
	private Vector2Control <thumbstick>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private AxisControl <trigger>k__BackingField; //Field offset: 0x124
	[CompilerGenerated]
	private AxisControl <grip>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private ButtonControl <primaryButton>k__BackingField; //Field offset: 0x12C
	[CompilerGenerated]
	private ButtonControl <secondaryButton>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private ButtonControl <gripPressed>k__BackingField; //Field offset: 0x134
	[CompilerGenerated]
	private ButtonControl <start>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private ButtonControl <thumbstickClicked>k__BackingField; //Field offset: 0x13C
	[CompilerGenerated]
	private ButtonControl <primaryTouched>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private ButtonControl <secondaryTouched>k__BackingField; //Field offset: 0x144
	[CompilerGenerated]
	private AxisControl <triggerTouched>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private ButtonControl <triggerPressed>k__BackingField; //Field offset: 0x14C
	[CompilerGenerated]
	private ButtonControl <thumbstickTouched>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x154
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	private Vector3Control <deviceAcceleration>k__BackingField; //Field offset: 0x15C
	[CompilerGenerated]
	private Vector3Control <deviceAngularAcceleration>k__BackingField; //Field offset: 0x160

	[InputControl(noisy = True, aliases = new IL2CPP_TYPE_STRING[] {"controllerAcceleration"})]
	public Vector3Control deviceAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True, aliases = new IL2CPP_TYPE_STRING[] {"controllerAngularAcceleration"})]
	public Vector3Control deviceAngularAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True, aliases = new IL2CPP_TYPE_STRING[] {"controllerAngularVelocity"})]
	public Vector3Control deviceAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True, aliases = new IL2CPP_TYPE_STRING[] {"controllerVelocity"})]
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

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"GripButton"})]
	public ButtonControl gripPressed
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"A", "X", "Alternate"})]
	public ButtonControl primaryButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"ATouched", "XTouched", "ATouch", "XTouch"})]
	public ButtonControl primaryTouched
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"B", "Y", "Primary"})]
	public ButtonControl secondaryButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"BTouched", "YTouched", "BTouch", "YTouch"})]
	public ButtonControl secondaryTouched
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl]
	public ButtonControl start
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"Primary2DAxis", "Joystick"})]
	public Vector2Control thumbstick
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"JoystickOrPadPressed", "thumbstickClick"})]
	public ButtonControl thumbstickClicked
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"JoystickOrPadTouched", "thumbstickTouch"})]
	[InputControl(name = "trackingState", layout = "Integer", aliases = new IL2CPP_TYPE_STRING[] {"controllerTrackingState"})]
	[InputControl(name = "isTracked", layout = "Button", aliases = new IL2CPP_TYPE_STRING[] {"ControllerIsTracked"})]
	[InputControl(name = "devicePosition", layout = "Vector3", aliases = new IL2CPP_TYPE_STRING[] {"controllerPosition"})]
	[InputControl(name = "deviceRotation", layout = "Quaternion", aliases = new IL2CPP_TYPE_STRING[] {"controllerRotation"})]
	public ButtonControl thumbstickTouched
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

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"indexButton", "indexTouched"})]
	public ButtonControl triggerPressed
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"indexTouch", "indexNearTouched"})]
	public AxisControl triggerTouched
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public OculusTouchController() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAngularAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_deviceVelocity() { }

	[CompilerGenerated]
	public AxisControl get_grip() { }

	[CompilerGenerated]
	public ButtonControl get_gripPressed() { }

	[CompilerGenerated]
	public ButtonControl get_primaryButton() { }

	[CompilerGenerated]
	public ButtonControl get_primaryTouched() { }

	[CompilerGenerated]
	public ButtonControl get_secondaryButton() { }

	[CompilerGenerated]
	public ButtonControl get_secondaryTouched() { }

	[CompilerGenerated]
	public ButtonControl get_start() { }

	[CompilerGenerated]
	public Vector2Control get_thumbstick() { }

	[CompilerGenerated]
	public ButtonControl get_thumbstickClicked() { }

	[CompilerGenerated]
	public ButtonControl get_thumbstickTouched() { }

	[CompilerGenerated]
	public AxisControl get_trigger() { }

	[CompilerGenerated]
	public ButtonControl get_triggerPressed() { }

	[CompilerGenerated]
	public AxisControl get_triggerTouched() { }

	[CompilerGenerated]
	protected void set_deviceAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_deviceAngularAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_deviceAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_deviceVelocity(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_grip(AxisControl value) { }

	[CompilerGenerated]
	protected void set_gripPressed(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_primaryButton(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_primaryTouched(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_secondaryButton(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_secondaryTouched(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_start(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_thumbstick(Vector2Control value) { }

	[CompilerGenerated]
	protected void set_thumbstickClicked(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_thumbstickTouched(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_trigger(AxisControl value) { }

	[CompilerGenerated]
	protected void set_triggerPressed(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_triggerTouched(AxisControl value) { }

}

