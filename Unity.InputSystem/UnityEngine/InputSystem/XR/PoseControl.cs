namespace UnityEngine.InputSystem.XR;

[InputControlLayout(stateType = typeof(PoseState))]
[Preserve]
public class PoseControl : InputControl<PoseState>
{
	[CompilerGenerated]
	private ButtonControl <isTracked>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private IntegerControl <trackingState>k__BackingField; //Field offset: 0x134
	[CompilerGenerated]
	private Vector3Control <position>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private QuaternionControl <rotation>k__BackingField; //Field offset: 0x13C
	[CompilerGenerated]
	private Vector3Control <velocity>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private Vector3Control <angularVelocity>k__BackingField; //Field offset: 0x144

	public Vector3Control angularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ButtonControl isTracked
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Vector3Control position
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public QuaternionControl rotation
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public IntegerControl trackingState
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Vector3Control velocity
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public PoseControl() { }

	protected virtual FourCC CalculateOptimizedControlDataType() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public Vector3Control get_angularVelocity() { }

	[CompilerGenerated]
	public ButtonControl get_isTracked() { }

	[CompilerGenerated]
	public Vector3Control get_position() { }

	[CompilerGenerated]
	public QuaternionControl get_rotation() { }

	[CompilerGenerated]
	public IntegerControl get_trackingState() { }

	[CompilerGenerated]
	public Vector3Control get_velocity() { }

	public virtual PoseState ReadUnprocessedValueFromState(Void* statePtr) { }

	[CompilerGenerated]
	public void set_angularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	public void set_isTracked(ButtonControl value) { }

	[CompilerGenerated]
	public void set_position(Vector3Control value) { }

	[CompilerGenerated]
	public void set_rotation(QuaternionControl value) { }

	[CompilerGenerated]
	public void set_trackingState(IntegerControl value) { }

	[CompilerGenerated]
	public void set_velocity(Vector3Control value) { }

	public virtual void WriteValueIntoState(PoseState value, Void* statePtr) { }

}

