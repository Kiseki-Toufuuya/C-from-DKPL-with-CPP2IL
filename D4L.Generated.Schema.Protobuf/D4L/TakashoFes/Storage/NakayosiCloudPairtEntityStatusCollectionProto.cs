namespace D4L.TakashoFes.Storage;

public sealed class NakayosiCloudPairtEntityStatusCollectionProto : IMessage<NakayosiCloudPairtEntityStatusCollectionProto>, IMessage, IEquatable<NakayosiCloudPairtEntityStatusCollectionProto>, IDeepCloneable<NakayosiCloudPairtEntityStatusCollectionProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal NakayosiCloudPairtEntityStatusCollectionProto <.cctor>b__30_0() { }

	}

	private static readonly MessageParser<NakayosiCloudPairtEntityStatusCollectionProto> _parser; //Field offset: 0x0
	private static readonly Codec<Int64, Int64> _map_nakayosiPt_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly MapField<Int64, Int64> nakayosiPt_; //Field offset: 0x18

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
	public MapField<Int64, Int64> NakayosiPt
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public static MessageParser<NakayosiCloudPairtEntityStatusCollectionProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static NakayosiCloudPairtEntityStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public NakayosiCloudPairtEntityStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public NakayosiCloudPairtEntityStatusCollectionProto(NakayosiCloudPairtEntityStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override NakayosiCloudPairtEntityStatusCollectionProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(NakayosiCloudPairtEntityStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public MapField<Int64, Int64> get_NakayosiPt() { }

	public static MessageParser<NakayosiCloudPairtEntityStatusCollectionProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(NakayosiCloudPairtEntityStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

