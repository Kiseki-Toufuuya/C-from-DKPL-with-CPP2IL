namespace UnityEngine;

[AttributeUsage(AttributeTargets::Enum (16))]
public sealed class InspectorOrderAttribute : PropertyAttribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private InspectorSort <m_inspectorSort>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private InspectorSortDirection <m_sortDirection>k__BackingField; //Field offset: 0x10

	internal InspectorSort m_inspectorSort
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	internal InspectorSortDirection m_sortDirection
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	[CompilerGenerated]
	internal InspectorSort get_m_inspectorSort() { }

	[CompilerGenerated]
	internal InspectorSortDirection get_m_sortDirection() { }

}

