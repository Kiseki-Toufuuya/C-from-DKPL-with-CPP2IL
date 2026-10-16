namespace UnityEngine.Localization.SmartFormat.Core.Parsing;

public class Format : FormatItem
{
	[DefaultMember("Item")]
	public class SplitList : IList<Format>, ICollection<Format>, IEnumerable<Format>, IEnumerable
	{
		private Format m_Format; //Field offset: 0x8
		private List<Int32> m_Splits; //Field offset: 0xC
		private List<Format> m_FormatCache; //Field offset: 0x10

		public override int Count
		{
			 get { } //Length: 53
		}

		public override bool IsReadOnly
		{
			 get { } //Length: 3
		}

		public override Format Item
		{
			 get { } //Length: 508
			 set { } //Length: 47
		}

		public SplitList() { }

		public override void Add(Format item) { }

		public override void Clear() { }

		public override bool Contains(Format item) { }

		public override void CopyTo(Format[] array, int arrayIndex) { }

		public override int get_Count() { }

		public override bool get_IsReadOnly() { }

		public override Format get_Item(int index) { }

		public override IEnumerator<Format> GetEnumerator() { }

		public override int IndexOf(Format item) { }

		public void Init(Format format, List<Int32> splits) { }

		public override void Insert(int index, Format item) { }

		public override bool Remove(Format item) { }

		public override void RemoveAt(int index) { }

		public override void set_Item(int index, Format value) { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	public Placeholder parent; //Field offset: 0x20
	[CompilerGenerated]
	private readonly List<FormatItem> <Items>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private bool <HasNested>k__BackingField; //Field offset: 0x28
	private List<SplitList> m_Splits; //Field offset: 0x2C
	private char splitCacheChar; //Field offset: 0x30
	private IList<Format> splitCache; //Field offset: 0x34

	public bool HasNested
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public List<FormatItem> Items
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public Format() { }

	private List<Int32> FindAll(char search) { }

	private List<Int32> FindAll(char search, int maxCount) { }

	[CompilerGenerated]
	public bool get_HasNested() { }

	[CompilerGenerated]
	public List<FormatItem> get_Items() { }

	public string GetLiteralText() { }

	public int IndexOf(char search) { }

	public int IndexOf(char search, int startIndex) { }

	public void ReleaseToPool() { }

	[CompilerGenerated]
	public void set_HasNested(bool value) { }

	public IList<Format> Split(char search) { }

	public IList<Format> Split(char search, int maxCount) { }

	public Format Substring(int startIndex) { }

	public Format Substring(int startIndex, int length) { }

	public virtual string ToString() { }

}

