namespace D4L.TakashoFes.Storage;

public sealed class TweetStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override TweetStatusEntry Parse(Byte[] source) { }

		public TweetStatusEntry Parse(TweetStatusProto source) { }

		public override Byte[] ToBytes(TweetStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardBool <IsUnlock>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardBool <IsRead>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <New>k__BackingField; //Field offset: 0x30

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

	public GuardBool IsRead
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardBool IsUnlock
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

	public int New
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public TweetStatusEntry() { }

	[Preserve]
	public override TweetStatusEntry Clone() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public GuardBool get_IsRead() { }

	[CompilerGenerated]
	public GuardBool get_IsUnlock() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public int get_New() { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_IsRead(GuardBool value) { }

	[CompilerGenerated]
	public void set_IsUnlock(GuardBool value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_New(int value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

