namespace Google.Protobuf.WellKnownTypes;

public sealed class Any : IMessage<Any>, IMessage, IEquatable<Any>, IDeepCloneable<Any>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Any <.cctor>b__38_0() { }

	}

	private static readonly MessageParser<Any> _parser; //Field offset: 0x0
	public const int TypeUrlFieldNumber = 1; //Field offset: 0x0
	public const int ValueFieldNumber = 2; //Field offset: 0x0
	private const string DefaultPrefix = "type.googleapis.com"; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private string typeUrl_; //Field offset: 0xC
	private ByteString value_; //Field offset: 0x10

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public static MessageParser<Any> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public string TypeUrl
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public ByteString Value
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	private static Any() { }

	[DebuggerNonUserCode]
	public Any() { }

	[DebuggerNonUserCode]
	public Any(Any other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Any Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(Any other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<Any> get_Parser() { }

	public string get_TypeUrl() { }

	public ByteString get_Value() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	public static string GetTypeName(string typeUrl) { }

	private static string GetTypeUrl(MessageDescriptor descriptor, string prefix) { }

	public bool Is(MessageDescriptor descriptor) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Any other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	public static Any Pack(IMessage message, string typeUrlPrefix) { }

	public static Any Pack(IMessage message) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_TypeUrl(string value) { }

	public void set_Value(ByteString value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	public bool TryUnpack(out T result) { }

	public T Unpack() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

