namespace Unity.Hierarchy;

[DefaultMember("Item")]
[IsReadOnly]
public struct HierarchyNodeChildren
{
	internal struct Enumerator
	{
		private readonly HierarchyNodeChildren m_Enumerable; //Field offset: 0x0
		private int m_Index; //Field offset: 0x10

		[IsReadOnly]
		public HierarchyNode Current
		{
			 get { } //Length: 132
		}

		internal Enumerator(in HierarchyNodeChildren enumerable) { }

		public HierarchyNode get_Current() { }

		public bool MoveNext() { }

	}

	private readonly Hierarchy m_Hierarchy; //Field offset: 0x0
	private readonly HierarchyNode* m_Ptr; //Field offset: 0x4
	private readonly int m_Version; //Field offset: 0x8
	private readonly int m_Count; //Field offset: 0xC

	internal HierarchyNodeChildren(Hierarchy hierarchy, IntPtr nodeChildrenPtr) { }

	public Enumerator GetEnumerator() { }

	private void ThrowIfVersionChanged() { }

}

