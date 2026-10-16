namespace D4L.TakashoFes.Storage;

public sealed class SaveHashProto : IMessage<SaveHashProto>, IMessage, IEquatable<SaveHashProto>, IDeepCloneable<SaveHashProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal SaveHashProto <.cctor>b__40_0() { }

	}

	private static readonly MessageParser<SaveHashProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private string hashValue_; //Field offset: 0x18
	private string annotation_; //Field offset: 0x1C
	private long date_; //Field offset: 0x20

	[DebuggerNonUserCode]
	public string Annotation
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public long Date
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
	public string HashValue
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public long ID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageParser<SaveHashProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static SaveHashProto() { }

	[DebuggerNonUserCode]
	public SaveHashProto() { }

	[DebuggerNonUserCode]
	public SaveHashProto(SaveHashProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override SaveHashProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(SaveHashProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public string get_Annotation() { }

	public long get_Date() { }

	public static MessageDescriptor get_Descriptor() { }

	public string get_HashValue() { }

	public long get_ID() { }

	public static MessageParser<SaveHashProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(SaveHashProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Annotation(string value) { }

	public void set_Date(long value) { }

	public void set_HashValue(string value) { }

	public void set_ID(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

