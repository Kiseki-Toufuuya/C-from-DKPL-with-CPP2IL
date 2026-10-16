namespace Unity.XR.OpenVR;

[InputControlLayout(displayName = "OpenVR Headset", hideInUI = True)]
public class OpenVRHMD : XRHMD
{
	[CompilerGenerated]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x13C
	[CompilerGenerated]
	private Vector3Control <leftEyeVelocity>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private Vector3Control <leftEyeAngularVelocity>k__BackingField; //Field offset: 0x144
	[CompilerGenerated]
	private Vector3Control <rightEyeVelocity>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private Vector3Control <rightEyeAngularVelocity>k__BackingField; //Field offset: 0x14C
	[CompilerGenerated]
	private Vector3Control <centerEyeVelocity>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private Vector3Control <centerEyeAngularVelocity>k__BackingField; //Field offset: 0x154

	[InputControl(noisy = True)]
	public Vector3Control centerEyeAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(noisy = True)]
	public Vector3Control centerEyeVelocity
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
	public Vector3Control deviceVelocity
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
	public Vector3Control leftEyeVelocity
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

	[InputControl(noisy = True)]
	public Vector3Control rightEyeVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public OpenVRHMD() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public Vector3Control get_centerEyeAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_centerEyeVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_deviceVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_leftEyeAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_leftEyeVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_rightEyeAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_rightEyeVelocity() { }

	[CompilerGenerated]
	protected void set_centerEyeAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_centerEyeVelocity(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_deviceAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_deviceVelocity(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_leftEyeAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_leftEyeVelocity(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_rightEyeAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	protected void set_rightEyeVelocity(Vector3Control value) { }

}

