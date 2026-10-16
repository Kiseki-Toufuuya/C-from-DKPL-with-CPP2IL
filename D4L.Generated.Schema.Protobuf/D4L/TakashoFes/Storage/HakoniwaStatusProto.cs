namespace D4L.TakashoFes.Storage;

public sealed class HakoniwaStatusProto : IMessage<HakoniwaStatusProto>, IMessage, IEquatable<HakoniwaStatusProto>, IDeepCloneable<HakoniwaStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal HakoniwaStatusProto <.cctor>b__50_0() { }

	}

	private static readonly MessageParser<HakoniwaStatusProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<SpotVisitRecordProto> _repeated_spotVisitRecord_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int partyPt_; //Field offset: 0x18
	private long createdAt_; //Field offset: 0x20
	private long lastUpdate_; //Field offset: 0x28
	private long nextVisitUpdate_; //Field offset: 0x30
	private readonly RepeatedField<SpotVisitRecordProto> spotVisitRecord_; //Field offset: 0x38

	[DebuggerNonUserCode]
	public long CreatedAt
	{
		 get { } //Length: 14
		 set { } //Length: 20
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
	public long LastUpdate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long NextVisitUpdate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageParser<HakoniwaStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	public int PartyPt
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public RepeatedField<SpotVisitRecordProto> SpotVisitRecord
	{
		 get { } //Length: 11
	}

	private static HakoniwaStatusProto() { }

	[DebuggerNonUserCode]
	public HakoniwaStatusProto() { }

	[DebuggerNonUserCode]
	public HakoniwaStatusProto(HakoniwaStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override HakoniwaStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(HakoniwaStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public long get_NextVisitUpdate() { }

	public static MessageParser<HakoniwaStatusProto> get_Parser() { }

	public int get_PartyPt() { }

	public RepeatedField<SpotVisitRecordProto> get_SpotVisitRecord() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(HakoniwaStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CreatedAt(long value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_NextVisitUpdate(long value) { }

	public void set_PartyPt(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

