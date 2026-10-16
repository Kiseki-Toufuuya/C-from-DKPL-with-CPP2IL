namespace D4L.TakashoFes.Storage;

public sealed class NakayosiCloudPairStatusProto : IMessage<NakayosiCloudPairStatusProto>, IMessage, IEquatable<NakayosiCloudPairStatusProto>, IDeepCloneable<NakayosiCloudPairStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal NakayosiCloudPairStatusProto <.cctor>b__50_0() { }

	}

	private static readonly MessageParser<NakayosiCloudPairStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int character1ID_; //Field offset: 0x18
	private int character2ID_; //Field offset: 0x1C
	private int nakayosiPt_; //Field offset: 0x20
	private long createdAt_; //Field offset: 0x28
	private long lastUpdate_; //Field offset: 0x30

	[DebuggerNonUserCode]
	public int Character1ID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int Character2ID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

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
	public int NakayosiPt
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<NakayosiCloudPairStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static NakayosiCloudPairStatusProto() { }

	[DebuggerNonUserCode]
	public NakayosiCloudPairStatusProto() { }

	[DebuggerNonUserCode]
	public NakayosiCloudPairStatusProto(NakayosiCloudPairStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override NakayosiCloudPairStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(NakayosiCloudPairStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public int get_Character1ID() { }

	public int get_Character2ID() { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public int get_NakayosiPt() { }

	public static MessageParser<NakayosiCloudPairStatusProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(NakayosiCloudPairStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Character1ID(int value) { }

	public void set_Character2ID(int value) { }

	public void set_CreatedAt(long value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_NakayosiPt(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

