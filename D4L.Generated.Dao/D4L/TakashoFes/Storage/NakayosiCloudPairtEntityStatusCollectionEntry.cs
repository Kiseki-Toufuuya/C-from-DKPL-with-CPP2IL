namespace D4L.TakashoFes.Storage;

public sealed class NakayosiCloudPairtEntityStatusCollectionEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override NakayosiCloudPairtEntityStatusCollectionEntry Parse(Byte[] source) { }

		public NakayosiCloudPairtEntityStatusCollectionEntry Parse(NakayosiCloudPairtEntityStatusCollectionProto source) { }

		public override Byte[] ToBytes(NakayosiCloudPairtEntityStatusCollectionEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Dictionary<Int64, Int64> <NakayosiPt>k__BackingField; //Field offset: 0x10

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public Dictionary<Int64, Int64> NakayosiPt
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public NakayosiCloudPairtEntityStatusCollectionEntry() { }

	[Preserve]
	public override NakayosiCloudPairtEntityStatusCollectionEntry Clone() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public Dictionary<Int64, Int64> get_NakayosiPt() { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_NakayosiPt(Dictionary<Int64, Int64> value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

