namespace UnityEngine.UIElements.UIR;

internal class EntryPreProcessor
{
	internal struct AllocSize
	{
		public int vertexCount; //Field offset: 0x0
		public int indexCount; //Field offset: 0x4

	}

	private int m_ChildrenIndex; //Field offset: 0x8
	private List<AllocSize> m_Allocs; //Field offset: 0xC
	private List<AllocSize> m_HeadAllocs; //Field offset: 0x10
	private List<AllocSize> m_TailAllocs; //Field offset: 0x14
	private List<Entry> m_FlattenedEntries; //Field offset: 0x18
	private AllocSize m_Pending; //Field offset: 0x1C
	private Stack<AllocSize> m_Mask; //Field offset: 0x24
	private bool m_IsPushingMask; //Field offset: 0x28

	public int childrenIndex
	{
		 get { } //Length: 11
	}

	public List<Entry> flattenedEntries
	{
		 get { } //Length: 11
	}

	public List<AllocSize> headAllocs
	{
		 get { } //Length: 11
	}

	public List<AllocSize> tailAllocs
	{
		 get { } //Length: 11
	}

	public EntryPreProcessor() { }

	private void Add(int vertexCount, int indexCount) { }

	public void ClearReferences() { }

	private void DoEvaluate(Entry entry) { }

	private void Flush() { }

	public int get_childrenIndex() { }

	public List<Entry> get_flattenedEntries() { }

	public List<AllocSize> get_headAllocs() { }

	public List<AllocSize> get_tailAllocs() { }

	public void PreProcess(Entry root) { }

}

