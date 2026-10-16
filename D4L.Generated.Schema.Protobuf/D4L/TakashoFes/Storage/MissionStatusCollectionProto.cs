namespace D4L.TakashoFes.Storage;

public sealed class MissionStatusCollectionProto : IMessage<MissionStatusCollectionProto>, IMessage, IEquatable<MissionStatusCollectionProto>, IDeepCloneable<MissionStatusCollectionProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal MissionStatusCollectionProto <.cctor>b__35_0() { }

	}

	private static readonly MessageParser<MissionStatusCollectionProto> _parser; //Field offset: 0x0
	private static readonly Codec<Int64, Int64> _map_progress_codec; //Field offset: 0x4
	private static readonly Codec<Int64, Int32> _map_receiveStatus_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly MapField<Int64, Int64> progress_; //Field offset: 0x18
	private readonly MapField<Int64, Int32> receiveStatus_; //Field offset: 0x1C

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
	public static MessageParser<MissionStatusCollectionProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public MapField<Int64, Int64> Progress
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public MapField<Int64, Int32> ReceiveStatus
	{
		 get { } //Length: 11
	}

	private static MissionStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public MissionStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public MissionStatusCollectionProto(MissionStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override MissionStatusCollectionProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(MissionStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public static MessageParser<MissionStatusCollectionProto> get_Parser() { }

	public MapField<Int64, Int64> get_Progress() { }

	public MapField<Int64, Int32> get_ReceiveStatus() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(MissionStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

