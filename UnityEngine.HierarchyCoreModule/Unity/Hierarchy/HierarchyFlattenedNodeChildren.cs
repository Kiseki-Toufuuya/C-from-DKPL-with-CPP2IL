namespace Unity.Hierarchy;

[DefaultMember("Item")]
[IsReadOnly]
public struct HierarchyFlattenedNodeChildren
{
	internal struct Enumerator
	{
		private readonly HierarchyFlattenedNodeChildren m_Enumerable; //Field offset: 0x0
		private readonly HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x14
		private readonly HierarchyNode m_Node; //Field offset: 0x18
		private int m_CurrentIndex; //Field offset: 0x20
		private int m_ChildrenIndex; //Field offset: 0x24
		private int m_ChildrenCount; //Field offset: 0x28

		[IsReadOnly]
		public HierarchyNode Current
		{
			 get { } //Length: 47
		}

		internal Enumerator(HierarchyFlattenedNodeChildren enumerable, HierarchyNode node) { }

		public HierarchyNode get_Current() { }

		public bool MoveNext() { }

	}

	private readonly HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x0
	private readonly HierarchyNode m_Node; //Field offset: 0x4
	private readonly int m_Version; //Field offset: 0xC
	private readonly int m_Count; //Field offset: 0x10

	internal HierarchyFlattenedNodeChildren(HierarchyFlattened hierarchyFlattened, in HierarchyNode node) { }

	public Enumerator GetEnumerator() { }

	private void ThrowIfVersionChanged() { }

}

