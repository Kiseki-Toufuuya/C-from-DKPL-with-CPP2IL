namespace UnityEngine.Timeline;

internal class IntervalTree
{
	public struct Entry
	{
		public long intervalStart; //Field offset: 0x0
		public long intervalEnd; //Field offset: 0x0
		public T item; //Field offset: 0x0

	}

	private const int kMinNodeSize = 10; //Field offset: 0x0
	private const int kInvalidNode = -1; //Field offset: 0x0
	private const long kCenterUnknown = 9223372036854775807; //Field offset: 0x0
	private readonly List<Entry<T>> m_Entries; //Field offset: 0x0
	private readonly List<IntervalTreeNode> m_Nodes; //Field offset: 0x0
	[CompilerGenerated]
	private bool <dirty>k__BackingField; //Field offset: 0x0

	public internal bool dirty
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public IntervalTree`1() { }

	public void Add(T item) { }

	public void Clear() { }

	[CompilerGenerated]
	public bool get_dirty() { }

	public void IntersectsWith(long value, List<T> results) { }

	public void IntersectsWithRange(long start, long end, List<T> results) { }

	private void Query(IntervalTreeNode intervalTreeNode, long value, List<T> results) { }

	private void QueryRange(IntervalTreeNode intervalTreeNode, long start, long end, List<T> results) { }

	private void Rebuild() { }

	private int Rebuild(int start, int end) { }

	[CompilerGenerated]
	internal void set_dirty(bool value) { }

	public void UpdateIntervals() { }

}

