namespace D4L.TakashoFes.Storage;

public sealed class HeqetPlayerDataEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override HeqetPlayerDataEntry Parse(Byte[] source) { }

		public HeqetPlayerDataEntry Parse(HeqetPlayerDataProto source) { }

		public override Byte[] ToBytes(HeqetPlayerDataEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <PlayerName>k__BackingField; //Field offset: 0x10

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public string PlayerName
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public HeqetPlayerDataEntry() { }

	[Preserve]
	public override HeqetPlayerDataEntry Clone() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public string get_PlayerName() { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_PlayerName(string value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

