namespace UnityEngine.UIElements.Layout;

internal struct LayoutNodeData
{
	[Flags]
	public enum FlexStatus
	{
		IsDirty = 1,
		HasNewLayout = 4,
		DependsOnParentSize = 64,
		Fixed = 8,
		MinViolation = 16,
		MaxViolation = 32,
	}

	public FixedBuffer2<LayoutValue> ResolvedDimensions; //Field offset: 0x0
	private float TargetSize; //Field offset: 0x10
	public int ManagedMeasureFunctionIndex; //Field offset: 0x14
	public int ManagedBaselineFunctionIndex; //Field offset: 0x18
	public int ManagedOwnerIndex; //Field offset: 0x1C
	public int LineIndex; //Field offset: 0x20
	public LayoutHandle Config; //Field offset: 0x24
	public LayoutHandle Parent; //Field offset: 0x2C
	public LayoutHandle NextChild; //Field offset: 0x34
	public LayoutList<LayoutHandle> Children; //Field offset: 0x3C
	private FlexStatus Status; //Field offset: 0x44

	public bool HasNewLayout
	{
		 get { } //Length: 16
		 set { } //Length: 29
	}

	public bool IsDirty
	{
		 get { } //Length: 13
		 set { } //Length: 29
	}

	public bool get_HasNewLayout() { }

	public bool get_IsDirty() { }

	public void set_HasNewLayout(bool value) { }

	public void set_IsDirty(bool value) { }

}

