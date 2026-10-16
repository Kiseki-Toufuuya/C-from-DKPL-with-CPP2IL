namespace D4L.TakashoFes.Storage;

public sealed class GpxInfoStatusEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Boolean, Boolean> <>9__61_1; //Field offset: 0x4
		public static Func<Int64, Int64> <>9__61_2; //Field offset: 0x8
		public static Func<Int64, Int64> <>9__61_3; //Field offset: 0xC
		public static Func<GpxPhaseStatus, Dictionary`2<String, Object>> <>9__61_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Dictionary<String, Object> <ToDict>b__61_0(GpxPhaseStatus ____) { }

		internal bool <ToDict>b__61_1(bool ______) { }

		internal long <ToDict>b__61_2(long ______) { }

		internal long <ToDict>b__61_3(long ______) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override GpxInfoStatusEntry Parse(Byte[] source) { }

		public GpxInfoStatusEntry Parse(GpxInfoStatusProto source) { }

		public override Byte[] ToBytes(GpxInfoStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GpxPhaseStatus[] <Phasees>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardInt <ReceiveReward>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private GuardInt <CurrentMedleyIndex>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private GuardInt <MedleyDifficulty>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private GuardInt <LastClassID>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private GuardInt <LastClassPeriod>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private GuardLong <ChallengingMedleyID>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private GuardLong <TicketDate>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private GuardBool <ReceivedTicket>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private GuardBool <IsBrowsedHelp>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private string <MedleySessionID>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private GuardLong <LogGpPoint>k__BackingField; //Field offset: 0x78

	public GuardLong ChallengingMedleyID
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardInt CurrentMedleyIndex
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

	public GuardBool IsBrowsedHelp
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt LastClassID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt LastClassPeriod
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardLong LogGpPoint
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardInt MedleyDifficulty
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public string MedleySessionID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public GpxPhaseStatus[] Phasees
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public GuardBool ReceivedTicket
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt ReceiveReward
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardLong TicketDate
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GpxInfoStatusEntry() { }

	[Preserve]
	public override GpxInfoStatusEntry Clone() { }

	[CompilerGenerated]
	public GuardLong get_ChallengingMedleyID() { }

	[CompilerGenerated]
	public GuardInt get_CurrentMedleyIndex() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public GuardBool get_IsBrowsedHelp() { }

	[CompilerGenerated]
	public GuardInt get_LastClassID() { }

	[CompilerGenerated]
	public GuardInt get_LastClassPeriod() { }

	[CompilerGenerated]
	public GuardLong get_LogGpPoint() { }

	[CompilerGenerated]
	public GuardInt get_MedleyDifficulty() { }

	[CompilerGenerated]
	public string get_MedleySessionID() { }

	[CompilerGenerated]
	public GpxPhaseStatus[] get_Phasees() { }

	[CompilerGenerated]
	public GuardBool get_ReceivedTicket() { }

	[CompilerGenerated]
	public GuardInt get_ReceiveReward() { }

	[CompilerGenerated]
	public GuardLong get_TicketDate() { }

	[CompilerGenerated]
	public void set_ChallengingMedleyID(GuardLong value) { }

	[CompilerGenerated]
	public void set_CurrentMedleyIndex(GuardInt value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_IsBrowsedHelp(GuardBool value) { }

	[CompilerGenerated]
	public void set_LastClassID(GuardInt value) { }

	[CompilerGenerated]
	public void set_LastClassPeriod(GuardInt value) { }

	[CompilerGenerated]
	public void set_LogGpPoint(GuardLong value) { }

	[CompilerGenerated]
	public void set_MedleyDifficulty(GuardInt value) { }

	[CompilerGenerated]
	public void set_MedleySessionID(string value) { }

	[CompilerGenerated]
	public void set_Phasees(GpxPhaseStatus[] value) { }

	[CompilerGenerated]
	public void set_ReceivedTicket(GuardBool value) { }

	[CompilerGenerated]
	public void set_ReceiveReward(GuardInt value) { }

	[CompilerGenerated]
	public void set_TicketDate(GuardLong value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

