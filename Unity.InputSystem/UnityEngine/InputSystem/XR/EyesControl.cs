namespace UnityEngine.InputSystem.XR;

public class EyesControl : InputControl<Eyes>
{
	[CompilerGenerated]
	private Vector3Control <leftEyePosition>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private QuaternionControl <leftEyeRotation>k__BackingField; //Field offset: 0x154
	[CompilerGenerated]
	private Vector3Control <rightEyePosition>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	private QuaternionControl <rightEyeRotation>k__BackingField; //Field offset: 0x15C
	[CompilerGenerated]
	private Vector3Control <fixationPoint>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	private AxisControl <leftEyeOpenAmount>k__BackingField; //Field offset: 0x164
	[CompilerGenerated]
	private AxisControl <rightEyeOpenAmount>k__BackingField; //Field offset: 0x168

	[InputControl(offset = 56, displayName = "FixationPoint")]
	public Vector3Control fixationPoint
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(offset = 68, displayName = "LeftEyeOpenAmount")]
	public AxisControl leftEyeOpenAmount
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(offset = 0, displayName = "LeftEyePosition")]
	public Vector3Control leftEyePosition
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(offset = 12, displayName = "LeftEyeRotation")]
	public QuaternionControl leftEyeRotation
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(offset = 72, displayName = "RightEyeOpenAmount")]
	public AxisControl rightEyeOpenAmount
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(offset = 28, displayName = "RightEyePosition")]
	public Vector3Control rightEyePosition
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(offset = 40, displayName = "RightEyeRotation")]
	public QuaternionControl rightEyeRotation
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public EyesControl() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public Vector3Control get_fixationPoint() { }

	[CompilerGenerated]
	public AxisControl get_leftEyeOpenAmount() { }

	[CompilerGenerated]
	public Vector3Control get_leftEyePosition() { }

	[CompilerGenerated]
	public QuaternionControl get_leftEyeRotation() { }

	[CompilerGenerated]
	public AxisControl get_rightEyeOpenAmount() { }

	[CompilerGenerated]
	public Vector3Control get_rightEyePosition() { }

	[CompilerGenerated]
	public QuaternionControl get_rightEyeRotation() { }

	public virtual Eyes ReadUnprocessedValueFromState(Void* statePtr) { }

	[CompilerGenerated]
	public void set_fixationPoint(Vector3Control value) { }

	[CompilerGenerated]
	public void set_leftEyeOpenAmount(AxisControl value) { }

	[CompilerGenerated]
	public void set_leftEyePosition(Vector3Control value) { }

	[CompilerGenerated]
	public void set_leftEyeRotation(QuaternionControl value) { }

	[CompilerGenerated]
	public void set_rightEyeOpenAmount(AxisControl value) { }

	[CompilerGenerated]
	public void set_rightEyePosition(Vector3Control value) { }

	[CompilerGenerated]
	public void set_rightEyeRotation(QuaternionControl value) { }

	public virtual void WriteValueIntoState(Eyes value, Void* statePtr) { }

}

