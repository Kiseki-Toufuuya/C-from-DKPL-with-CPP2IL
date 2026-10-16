namespace D4L.TakashoFes.Storage;

public sealed class PhotoStatusProto : IMessage<PhotoStatusProto>, IMessage, IEquatable<PhotoStatusProto>, IDeepCloneable<PhotoStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PhotoStatusProto <.cctor>b__50_0() { }

	}

	private static readonly MessageParser<PhotoStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private string title_; //Field offset: 0x18
	private string photoID_; //Field offset: 0x1C
	private bool favorate_; //Field offset: 0x20
	private long createdAt_; //Field offset: 0x28
	private long lastUpdate_; //Field offset: 0x30

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
	public bool Favorate
	{
		 get { } //Length: 11
		 set { } //Length: 14
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
	public static MessageParser<PhotoStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public string PhotoID
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public string Title
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	private static PhotoStatusProto() { }

	[DebuggerNonUserCode]
	public PhotoStatusProto() { }

	[DebuggerNonUserCode]
	public PhotoStatusProto(PhotoStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override PhotoStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(PhotoStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_Favorate() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public static MessageParser<PhotoStatusProto> get_Parser() { }

	public string get_PhotoID() { }

	public string get_Title() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(PhotoStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CreatedAt(long value) { }

	public void set_Favorate(bool value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_PhotoID(string value) { }

	public void set_Title(string value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

