namespace D4L.TakashoFes.Storage;

public sealed class NakayosiCloudPairStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override NakayosiCloudPairStatusEntry Parse(Byte[] source) { }

		public NakayosiCloudPairStatusEntry Parse(NakayosiCloudPairStatusProto source) { }

		public override Byte[] ToBytes(NakayosiCloudPairStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <Character1ID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardInt <Character2ID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private GuardInt <NakayosiPt>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x30

	public GuardInt Character1ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt Character2ID
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

	public GuardInt NakayosiPt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public NakayosiCloudPairStatusEntry() { }

	[Preserve]
	public override NakayosiCloudPairStatusEntry Clone() { }

	[CompilerGenerated]
	public GuardInt get_Character1ID() { }

	[CompilerGenerated]
	public GuardInt get_Character2ID() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public GuardInt get_NakayosiPt() { }

	[CompilerGenerated]
	public void set_Character1ID(GuardInt value) { }

	[CompilerGenerated]
	public void set_Character2ID(GuardInt value) { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_NakayosiPt(GuardInt value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

