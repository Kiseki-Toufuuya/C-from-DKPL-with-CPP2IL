namespace D4L.TakashoFes.Storage;

public sealed class SpotStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override SpotStatusEntry Parse(Byte[] source) { }

		public SpotStatusEntry Parse(SpotStatusProto source) { }

		public override Byte[] ToBytes(SpotStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <PartyCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardInt <ManzokuPt>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private GuardInt <PositionX>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private GuardInt <PositionY>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private GuardInt <ConstructionStatus>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private GuardInt <Reconstruction>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private int <New>k__BackingField; //Field offset: 0x50

	public GuardInt ConstructionStatus
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

	public GuardInt ManzokuPt
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

	public GuardInt PartyCount
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt PositionX
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt PositionY
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt Reconstruction
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public SpotStatusEntry() { }

	[Preserve]
	public override SpotStatusEntry Clone() { }

	[CompilerGenerated]
	public GuardInt get_ConstructionStatus() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public GuardInt get_ManzokuPt() { }

	[CompilerGenerated]
	public int get_New() { }

	[CompilerGenerated]
	public GuardInt get_PartyCount() { }

	[CompilerGenerated]
	public GuardInt get_PositionX() { }

	[CompilerGenerated]
	public GuardInt get_PositionY() { }

	[CompilerGenerated]
	public GuardInt get_Reconstruction() { }

	[CompilerGenerated]
	public void set_ConstructionStatus(GuardInt value) { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_ManzokuPt(GuardInt value) { }

	[CompilerGenerated]
	public void set_New(int value) { }

	[CompilerGenerated]
	public void set_PartyCount(GuardInt value) { }

	[CompilerGenerated]
	public void set_PositionX(GuardInt value) { }

	[CompilerGenerated]
	public void set_PositionY(GuardInt value) { }

	[CompilerGenerated]
	public void set_Reconstruction(GuardInt value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

