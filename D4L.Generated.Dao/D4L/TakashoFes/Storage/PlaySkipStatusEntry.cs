namespace D4L.TakashoFes.Storage;

public sealed class PlaySkipStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override PlaySkipStatusEntry Parse(Byte[] source) { }

		public PlaySkipStatusEntry Parse(PlaySkipStatusProto source) { }

		public override Byte[] ToBytes(PlaySkipStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <Count>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x20

	public GuardInt Count
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public long CreatedAt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public long LastUpdate
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public PlaySkipStatusEntry() { }

	[Preserve]
	public override PlaySkipStatusEntry Clone() { }

	[CompilerGenerated]
	public GuardInt get_Count() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public void set_Count(GuardInt value) { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

