namespace D4L.TakashoFes.Storage;

public sealed class JoinClubStatusEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int64> <>9__53_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal long <ToDict>b__53_0(int ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override JoinClubStatusEntry Parse(Byte[] source) { }

		public JoinClubStatusEntry Parse(JoinClubStatusProto source) { }

		public override Byte[] ToBytes(JoinClubStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <Status>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <ClubID>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private string <ReadedMessageID>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Int32[] <UseStampHistory>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private long <WithdrawedAt>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <LastPositionID>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private string <LeaderShortID>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private string <ClubName>k__BackingField; //Field offset: 0x40

	public string ClubID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string ClubName
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
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

	public int LastPositionID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public long LastUpdate
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public string LeaderShortID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string ReadedMessageID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int Status
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public Int32[] UseStampHistory
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public long WithdrawedAt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public JoinClubStatusEntry() { }

	[Preserve]
	public override JoinClubStatusEntry Clone() { }

	[CompilerGenerated]
	public string get_ClubID() { }

	[CompilerGenerated]
	public string get_ClubName() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public int get_LastPositionID() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public string get_LeaderShortID() { }

	[CompilerGenerated]
	public string get_ReadedMessageID() { }

	[CompilerGenerated]
	public int get_Status() { }

	[CompilerGenerated]
	public Int32[] get_UseStampHistory() { }

	[CompilerGenerated]
	public long get_WithdrawedAt() { }

	[CompilerGenerated]
	public void set_ClubID(string value) { }

	[CompilerGenerated]
	public void set_ClubName(string value) { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastPositionID(int value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_LeaderShortID(string value) { }

	[CompilerGenerated]
	public void set_ReadedMessageID(string value) { }

	[CompilerGenerated]
	public void set_Status(int value) { }

	[CompilerGenerated]
	public void set_UseStampHistory(Int32[] value) { }

	[CompilerGenerated]
	public void set_WithdrawedAt(long value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

