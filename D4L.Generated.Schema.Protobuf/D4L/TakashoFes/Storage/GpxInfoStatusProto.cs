namespace D4L.TakashoFes.Storage;

public sealed class GpxInfoStatusProto : IMessage<GpxInfoStatusProto>, IMessage, IEquatable<GpxInfoStatusProto>, IDeepCloneable<GpxInfoStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal GpxInfoStatusProto <.cctor>b__85_0() { }

	}

	private static readonly MessageParser<GpxInfoStatusProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<GpxPhaseStatusProto> _repeated_phasees_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly RepeatedField<GpxPhaseStatusProto> phasees_; //Field offset: 0x18
	private int receiveReward_; //Field offset: 0x1C
	private int currentMedleyIndex_; //Field offset: 0x20
	private int medleyDifficulty_; //Field offset: 0x24
	private int lastClassID_; //Field offset: 0x28
	private int lastClassPeriod_; //Field offset: 0x2C
	private long challengingMedleyID_; //Field offset: 0x30
	private long ticketDate_; //Field offset: 0x38
	private bool receivedTicket_; //Field offset: 0x40
	private bool isBrowsedHelp_; //Field offset: 0x41
	private string medleySessionID_; //Field offset: 0x44
	private long logGpPoint_; //Field offset: 0x48

	[DebuggerNonUserCode]
	public long ChallengingMedleyID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int CurrentMedleyIndex
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public long ID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public bool IsBrowsedHelp
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int LastClassID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int LastClassPeriod
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long LogGpPoint
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int MedleyDifficulty
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public string MedleySessionID
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public static MessageParser<GpxInfoStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public RepeatedField<GpxPhaseStatusProto> Phasees
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public bool ReceivedTicket
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int ReceiveReward
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long TicketDate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	private static GpxInfoStatusProto() { }

	[DebuggerNonUserCode]
	public GpxInfoStatusProto() { }

	[DebuggerNonUserCode]
	public GpxInfoStatusProto(GpxInfoStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override GpxInfoStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(GpxInfoStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_ChallengingMedleyID() { }

	public int get_CurrentMedleyIndex() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public bool get_IsBrowsedHelp() { }

	public int get_LastClassID() { }

	public int get_LastClassPeriod() { }

	public long get_LogGpPoint() { }

	public int get_MedleyDifficulty() { }

	public string get_MedleySessionID() { }

	public static MessageParser<GpxInfoStatusProto> get_Parser() { }

	public RepeatedField<GpxPhaseStatusProto> get_Phasees() { }

	public bool get_ReceivedTicket() { }

	public int get_ReceiveReward() { }

	public long get_TicketDate() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(GpxInfoStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ChallengingMedleyID(long value) { }

	public void set_CurrentMedleyIndex(int value) { }

	public void set_ID(long value) { }

	public void set_IsBrowsedHelp(bool value) { }

	public void set_LastClassID(int value) { }

	public void set_LastClassPeriod(int value) { }

	public void set_LogGpPoint(long value) { }

	public void set_MedleyDifficulty(int value) { }

	public void set_MedleySessionID(string value) { }

	public void set_ReceivedTicket(bool value) { }

	public void set_ReceiveReward(int value) { }

	public void set_TicketDate(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

