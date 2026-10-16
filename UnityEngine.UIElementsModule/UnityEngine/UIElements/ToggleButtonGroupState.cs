namespace UnityEngine.UIElements;

[DefaultMember("Item")]
public struct ToggleButtonGroupState : IEquatable<ToggleButtonGroupState>, IComparable<ToggleButtonGroupState>
{
	[SerializeField]
	private ulong m_Data; //Field offset: 0x0
	[SerializeField]
	private int m_Length; //Field offset: 0x8

	internal ulong data
	{
		internal get { } //Length: 13
	}

	public bool Item
	{
		 get { } //Length: 218
		 set { } //Length: 230
	}

	public internal int length
	{
		 get { } //Length: 11
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 14
	}

	public ToggleButtonGroupState(ulong optionsBitMask, int length) { }

	public override int CompareTo(ToggleButtonGroupState other) { }

	public override bool Equals(ToggleButtonGroupState other) { }

	public virtual bool Equals(object obj) { }

	internal ulong get_data() { }

	public bool get_Item(int index) { }

	public int get_length() { }

	public Span<Int32> GetActiveOptions(Span<Int32> activeOptionsIndices) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(ToggleButtonGroupState lhs, ToggleButtonGroupState rhs) { }

	public static bool op_Inequality(ToggleButtonGroupState lhs, ToggleButtonGroupState rhs) { }

	public void ResetAllOptions() { }

	private void ResetOptions(int startingIndex) { }

	public void set_Item(int index, bool value) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_length(int value) { }

	public virtual string ToString() { }

}

