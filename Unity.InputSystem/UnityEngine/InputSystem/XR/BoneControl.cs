namespace UnityEngine.InputSystem.XR;

public class BoneControl : InputControl<Bone>
{
	[CompilerGenerated]
	private IntegerControl <parentBoneIndex>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private Vector3Control <position>k__BackingField; //Field offset: 0xFC
	[CompilerGenerated]
	private QuaternionControl <rotation>k__BackingField; //Field offset: 0x100

	[InputControl(offset = 0, displayName = "parentBoneIndex")]
	public IntegerControl parentBoneIndex
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(offset = 4, displayName = "Position")]
	public Vector3Control position
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(offset = 16, displayName = "Rotation")]
	public QuaternionControl rotation
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public BoneControl() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public IntegerControl get_parentBoneIndex() { }

	[CompilerGenerated]
	public Vector3Control get_position() { }

	[CompilerGenerated]
	public QuaternionControl get_rotation() { }

	public virtual Bone ReadUnprocessedValueFromState(Void* statePtr) { }

	[CompilerGenerated]
	public void set_parentBoneIndex(IntegerControl value) { }

	[CompilerGenerated]
	public void set_position(Vector3Control value) { }

	[CompilerGenerated]
	public void set_rotation(QuaternionControl value) { }

	public virtual void WriteValueIntoState(Bone value, Void* statePtr) { }

}

