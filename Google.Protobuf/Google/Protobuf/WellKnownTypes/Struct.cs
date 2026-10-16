namespace Google.Protobuf.WellKnownTypes;

public sealed class Struct : IMessage<Struct>, IMessage, IEquatable<Struct>, IDeepCloneable<Struct>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Struct <.cctor>b__25_0() { }

	}

	private static readonly MessageParser<Struct> _parser; //Field offset: 0x0
	public const int FieldsFieldNumber = 1; //Field offset: 0x0
	private static readonly Codec<String, Value> _map_fields_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private readonly MapField<String, Value> fields_; //Field offset: 0xC

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public MapField<String, Value> Fields
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public static MessageParser<Struct> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static Struct() { }

	[DebuggerNonUserCode]
	public Struct() { }

	[DebuggerNonUserCode]
	public Struct(Struct other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Struct Clone() { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[DebuggerNonUserCode]
	public override bool Equals(Struct other) { }

	public static MessageDescriptor get_Descriptor() { }

	public MapField<String, Value> get_Fields() { }

	public static MessageParser<Struct> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Struct other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

