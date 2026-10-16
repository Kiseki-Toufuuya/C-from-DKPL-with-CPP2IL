namespace Unity.XR.Oculus.Input;

[InputControlLayout(displayName = "Oculus Headset", hideInUI = True)]
public class OculusHMD : XRHMD
{
	[CompilerGenerated]
	private ButtonControl <userPresence>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x13C
	[CompilerGenerated]
	private Vector3Control <deviceAcceleration>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private Vector3Control <deviceAngularAcceleration>k__BackingField; //Field offset: 0x144
	[CompilerGenerated]
	private Vector3Control <leftEyeAngularVelocity>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private Vector3Control <leftEyeAcceleration>k__BackingField; //Field offset: 0x14C
	[CompilerGenerated]
	private Vector3Control <leftEyeAngularAcceleration>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private Vector3Control <rightEyeAngularVelocity>k__BackingField; //Field offset: 0x154
	[CompilerGenerated]
	private Vector3Control <rightEyeAcceleration>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	private Vector3Control <rightEyeAngularAcceleration>k__BackingField; //Field offset: 0x15C
	[CompilerGenerated]
	private Vector3Control <centerEyeAngularVelocity>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	private Vector3Control <centerEyeAcceleration>k__BackingField; //Field offset: 0x164
	[CompilerGenerated]
	private Vector3Control <centerEyeAngularAcceleration>k__BackingField; //Field offset: 0x168

	[InputControl(noisy = True)]
	public Vector3Control centerEyeAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True)]
	public Vector3Control centerEyeAngularAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True)]
	public Vector3Control centerEyeAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True)]
	public Vector3Control deviceAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True)]
	public Vector3Control deviceAngularAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True)]
	public Vector3Control deviceAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True)]
	public Vector3Control leftEyeAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True)]
	public Vector3Control leftEyeAngularAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True)]
	public Vector3Control leftEyeAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True)]
	public Vector3Control rightEyeAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True)]
	public Vector3Control rightEyeAngularAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True)]
	public Vector3Control rightEyeAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl]
	[InputControl(name = "trackingState", layout = "Integer", aliases = new IL2CPP_TYPE_STRING[] {"devicetrackingstate"})]
	[InputControl(name = "isTracked", layout = "Button", aliases = new IL2CPP_TYPE_STRING[] {"deviceistracked"})]
	public ButtonControl userPresence
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public OculusHMD() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public Vector3Control get_centerEyeAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_centerEyeAngularAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_centerEyeAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAngularAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_leftEyeAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_leftEyeAngularAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_leftEyeAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_rightEyeAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_rightEyeAngularAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_rightEyeAngularVelocity() { }

	[CompilerGenerated]
	public ButtonControl get_userPresence() { }

	[CompilerGenerated]
	protected void set_centerEyeAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_centerEyeAngularAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_centerEyeAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_deviceAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_deviceAngularAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_deviceAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_leftEyeAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_leftEyeAngularAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_leftEyeAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_rightEyeAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_rightEyeAngularAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_rightEyeAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_userPresence(ButtonControl value) { }

}

