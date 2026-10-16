namespace Google.Protobuf.WellKnownTypes;

public sealed class Field : IMessage<Field>, IMessage, IEquatable<Field>, IDeepCloneable<Field>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Field <.cctor>b__71_0() { }

	}

	[DebuggerNonUserCode]
	internal static class Types
	{
		internal enum Cardinality
		{
			Unknown = 0,
			Optional = 1,
			Required = 2,
			Repeated = 3,
		}

		internal enum Kind
		{
			TypeUnknown = 0,
			TypeDouble = 1,
			TypeFloat = 2,
			TypeInt64 = 3,
			TypeUint64 = 4,
			TypeInt32 = 5,
			TypeFixed64 = 6,
			TypeFixed32 = 7,
			TypeBool = 8,
			TypeString = 9,
			TypeGroup = 10,
			TypeMessage = 11,
			TypeBytes = 12,
			TypeUint32 = 13,
			TypeEnum = 14,
			TypeSfixed32 = 15,
			TypeSfixed64 = 16,
			TypeSint32 = 17,
			TypeSint64 = 18,
		}


	}

	private static readonly MessageParser<Field> _parser; //Field offset: 0x0
	public const int PackedFieldNumber = 8; //Field offset: 0x0
	public const int JsonNameFieldNumber = 10; //Field offset: 0x0
	public const int OneofIndexFieldNumber = 7; //Field offset: 0x0
	public const int DefaultValueFieldNumber = 11; //Field offset: 0x0
	public const int TypeUrlFieldNumber = 6; //Field offset: 0x0
	public const int NameFieldNumber = 4; //Field offset: 0x0
	public const int CardinalityFieldNumber = 2; //Field offset: 0x0
	public const int KindFieldNumber = 1; //Field offset: 0x0
	public const int NumberFieldNumber = 3; //Field offset: 0x0
	public const int OptionsFieldNumber = 9; //Field offset: 0x0
	private static readonly FieldCodec<Option> _repeated_options_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private Kind kind_; //Field offset: 0xC
	private Cardinality cardinality_; //Field offset: 0x10
	private int number_; //Field offset: 0x14
	private string name_; //Field offset: 0x18
	private string typeUrl_; //Field offset: 0x1C
	private int oneofIndex_; //Field offset: 0x20
	private bool packed_; //Field offset: 0x24
	private readonly RepeatedField<Option> options_; //Field offset: 0x28
	private string jsonName_; //Field offset: 0x2C
	private string defaultValue_; //Field offset: 0x30

	[DebuggerNonUserCode]
	public Cardinality Cardinality
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public string DefaultValue
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public string JsonName
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public Kind Kind
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public string Name
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public int Number
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int OneofIndex
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public RepeatedField<Option> Options
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public bool Packed
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<Field> Parser
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

	private static Field() { }

	[DebuggerNonUserCode]
	public Field() { }

	[DebuggerNonUserCode]
	public Field(Field other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Field Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(Field other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public Cardinality get_Cardinality() { }

	public string get_DefaultValue() { }

	public static MessageDescriptor get_Descriptor() { }

	public string get_JsonName() { }

	public Kind get_Kind() { }

	public string get_Name() { }

	public int get_Number() { }

	public int get_OneofIndex() { }

	public RepeatedField<Option> get_Options() { }

	public bool get_Packed() { }

	public static MessageParser<Field> get_Parser() { }

	public string get_TypeUrl() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Field other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Cardinality(Cardinality value) { }

	public void set_DefaultValue(string value) { }

	public void set_JsonName(string value) { }

	public void set_Kind(Kind value) { }

	public void set_Name(string value) { }

	public void set_Number(int value) { }

	public void set_OneofIndex(int value) { }

	public void set_Packed(bool value) { }

	public void set_TypeUrl(string value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

