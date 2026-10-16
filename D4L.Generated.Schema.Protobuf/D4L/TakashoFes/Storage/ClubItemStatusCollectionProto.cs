namespace D4L.TakashoFes.Storage;

public sealed class ClubItemStatusCollectionProto : IMessage<ClubItemStatusCollectionProto>, IMessage, IEquatable<ClubItemStatusCollectionProto>, IDeepCloneable<ClubItemStatusCollectionProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ClubItemStatusCollectionProto <.cctor>b__35_0() { }

	}

	private static readonly MessageParser<ClubItemStatusCollectionProto> _parser; //Field offset: 0x0
	private static readonly Codec<Int32, Int32> _map_haveItems_codec; //Field offset: 0x4
	private static readonly Codec<Int32, Int64> _map_receiveDate_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly MapField<Int32, Int32> haveItems_; //Field offset: 0x18
	private readonly MapField<Int32, Int64> receiveDate_; //Field offset: 0x1C

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public MapField<Int32, Int32> HaveItems
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public long ID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageParser<ClubItemStatusCollectionProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public MapField<Int32, Int64> ReceiveDate
	{
		 get { } //Length: 11
	}

	private static ClubItemStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public ClubItemStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public ClubItemStatusCollectionProto(ClubItemStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override ClubItemStatusCollectionProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(ClubItemStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public MapField<Int32, Int32> get_HaveItems() { }

	public long get_ID() { }

	public static MessageParser<ClubItemStatusCollectionProto> get_Parser() { }

	public MapField<Int32, Int64> get_ReceiveDate() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(ClubItemStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

