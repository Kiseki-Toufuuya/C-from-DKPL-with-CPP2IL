namespace D4L.TakashoFes.Storage;

public sealed class HakoniwaStatusEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int64> <>9__33_1; //Field offset: 0x4
		public static Func<SpotVisitRecord, Dictionary`2<String, Object>> <>9__33_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Dictionary<String, Object> <ToDict>b__33_0(SpotVisitRecord ____) { }

		internal long <ToDict>b__33_1(int ______) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override HakoniwaStatusEntry Parse(Byte[] source) { }

		public HakoniwaStatusEntry Parse(HakoniwaStatusProto source) { }

		public override Byte[] ToBytes(HakoniwaStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <PartyPt>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private long <NextVisitUpdate>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private SpotVisitRecord[] <SpotVisitRecord>k__BackingField; //Field offset: 0x30

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

	public long NextVisitUpdate
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt PartyPt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public SpotVisitRecord[] SpotVisitRecord
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public HakoniwaStatusEntry() { }

	[Preserve]
	public override HakoniwaStatusEntry Clone() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public long get_NextVisitUpdate() { }

	[CompilerGenerated]
	public GuardInt get_PartyPt() { }

	[CompilerGenerated]
	public SpotVisitRecord[] get_SpotVisitRecord() { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_NextVisitUpdate(long value) { }

	[CompilerGenerated]
	public void set_PartyPt(GuardInt value) { }

	[CompilerGenerated]
	public void set_SpotVisitRecord(SpotVisitRecord[] value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

