namespace D4L.TakashoFes.Storage;

public sealed class MySpotItemStatusProto : IMessage<MySpotItemStatusProto>, IMessage, IEquatable<MySpotItemStatusProto>, IDeepCloneable<MySpotItemStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal MySpotItemStatusProto <.cctor>b__50_0() { }

	}

	private static readonly MessageParser<MySpotItemStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int category_; //Field offset: 0x18
	private int itemValue_; //Field offset: 0x1C
	private long createdAt_; //Field offset: 0x20
	private long lastUpdate_; //Field offset: 0x28
	private int new_; //Field offset: 0x30

	[DebuggerNonUserCode]
	public int Category
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
	public int ItemValue
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long LastUpdate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int New
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<MySpotItemStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static MySpotItemStatusProto() { }

	[DebuggerNonUserCode]
	public MySpotItemStatusProto() { }

	[DebuggerNonUserCode]
	public MySpotItemStatusProto(MySpotItemStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override MySpotItemStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(MySpotItemStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public int get_Category() { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public int get_ItemValue() { }

	public long get_LastUpdate() { }

	public int get_New() { }

	public static MessageParser<MySpotItemStatusProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(MySpotItemStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Category(int value) { }

	public void set_CreatedAt(long value) { }

	public void set_ID(long value) { }

	public void set_ItemValue(int value) { }

	public void set_LastUpdate(long value) { }

	public void set_New(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

