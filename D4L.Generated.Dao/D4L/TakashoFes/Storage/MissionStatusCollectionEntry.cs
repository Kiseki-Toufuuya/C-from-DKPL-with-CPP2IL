namespace D4L.TakashoFes.Storage;

public sealed class MissionStatusCollectionEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override MissionStatusCollectionEntry Parse(Byte[] source) { }

		public MissionStatusCollectionEntry Parse(MissionStatusCollectionProto source) { }

		public override Byte[] ToBytes(MissionStatusCollectionEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Dictionary<Int64, Int64> <Progress>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Dictionary<Int64, SByte> <ReceiveStatus>k__BackingField; //Field offset: 0x14

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public Dictionary<Int64, Int64> Progress
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Dictionary<Int64, SByte> ReceiveStatus
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public MissionStatusCollectionEntry() { }

	[Preserve]
	public override MissionStatusCollectionEntry Clone() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public Dictionary<Int64, Int64> get_Progress() { }

	[CompilerGenerated]
	public Dictionary<Int64, SByte> get_ReceiveStatus() { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_Progress(Dictionary<Int64, Int64> value) { }

	[CompilerGenerated]
	public void set_ReceiveStatus(Dictionary<Int64, SByte> value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

