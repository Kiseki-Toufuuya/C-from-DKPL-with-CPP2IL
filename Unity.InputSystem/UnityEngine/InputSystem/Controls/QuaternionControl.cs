namespace UnityEngine.InputSystem.Controls;

public class QuaternionControl : InputControl<Quaternion>
{
	[CompilerGenerated]
	private AxisControl <x>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private AxisControl <y>k__BackingField; //Field offset: 0xDC
	[CompilerGenerated]
	private AxisControl <z>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private AxisControl <w>k__BackingField; //Field offset: 0xE4

	[InputControl(displayName = "W")]
	public AxisControl w
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(displayName = "X")]
	public AxisControl x
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(displayName = "Y")]
	public AxisControl y
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(displayName = "Z")]
	public AxisControl z
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public QuaternionControl() { }

	protected virtual FourCC CalculateOptimizedControlDataType() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public AxisControl get_w() { }

	[CompilerGenerated]
	public AxisControl get_x() { }

	[CompilerGenerated]
	public AxisControl get_y() { }

	[CompilerGenerated]
	public AxisControl get_z() { }

	public virtual Quaternion ReadUnprocessedValueFromState(Void* statePtr) { }

	[CompilerGenerated]
	public void set_w(AxisControl value) { }

	[CompilerGenerated]
	public void set_x(AxisControl value) { }

	[CompilerGenerated]
	public void set_y(AxisControl value) { }

	[CompilerGenerated]
	public void set_z(AxisControl value) { }

	public virtual void WriteValueIntoState(Quaternion value, Void* statePtr) { }

}

