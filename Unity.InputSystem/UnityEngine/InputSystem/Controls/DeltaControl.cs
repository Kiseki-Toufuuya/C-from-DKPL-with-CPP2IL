namespace UnityEngine.InputSystem.Controls;

[Preserve]
public class DeltaControl : Vector2Control
{
	[CompilerGenerated]
	private AxisControl <up>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private AxisControl <down>k__BackingField; //Field offset: 0xD4
	[CompilerGenerated]
	private AxisControl <left>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private AxisControl <right>k__BackingField; //Field offset: 0xDC

	[InputControl(useStateFrom = "y", parameters = "clamp=1,clampMin=-3.402823E+38,clampMax=0,invert", synthetic = True, displayName = "Down")]
	[Preserve]
	public AxisControl down
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(useStateFrom = "x", parameters = "clamp=1,clampMin=-3.402823E+38,clampMax=0,invert", synthetic = True, displayName = "Left")]
	[Preserve]
	public AxisControl left
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(useStateFrom = "x", parameters = "clamp=1,clampMin=0,clampMax=3.402823E+38", synthetic = True, displayName = "Right")]
	[Preserve]
	public AxisControl right
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[InputControl(useStateFrom = "y", parameters = "clamp=1,clampMin=0,clampMax=3.402823E+38", synthetic = True, displayName = "Up")]
	[Preserve]
	public AxisControl up
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public DeltaControl() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public AxisControl get_down() { }

	[CompilerGenerated]
	public AxisControl get_left() { }

	[CompilerGenerated]
	public AxisControl get_right() { }

	[CompilerGenerated]
	public AxisControl get_up() { }

	[CompilerGenerated]
	public void set_down(AxisControl value) { }

	[CompilerGenerated]
	public void set_left(AxisControl value) { }

	[CompilerGenerated]
	public void set_right(AxisControl value) { }

	[CompilerGenerated]
	public void set_up(AxisControl value) { }

}

