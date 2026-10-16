namespace Google.Protobuf.Reflection;

internal sealed class UninterpretedOption : IMessage<UninterpretedOption>, IMessage, IEquatable<UninterpretedOption>, IDeepCloneable<UninterpretedOption>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal UninterpretedOption <.cctor>b__81_0() { }

	}

	[DebuggerNonUserCode]
	internal static class Types
	{
		public sealed class NamePart : IMessage<NamePart>, IMessage, IEquatable<NamePart>, IDeepCloneable<NamePart>
		{
			[CompilerGenerated]
			private sealed class <>c
			{
				public static readonly <>c <>9; //Field offset: 0x0

				private static <>c() { }

				public <>c() { }

				internal NamePart <.cctor>b__39_0() { }

			}

			private static readonly MessageParser<NamePart> _parser; //Field offset: 0x0
			public const int NamePart_FieldNumber = 1; //Field offset: 0x0
			public const int IsExtensionFieldNumber = 2; //Field offset: 0x0
			private static readonly string NamePart_DefaultValue; //Field offset: 0x4
			private static readonly bool IsExtensionDefaultValue; //Field offset: 0x8
			private UnknownFieldSet _unknownFields; //Field offset: 0x8
			private int _hasBits0; //Field offset: 0xC
			private string namePart_; //Field offset: 0x10
			private bool isExtension_; //Field offset: 0x14

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				 get { } //Length: 105
			}

			[DebuggerNonUserCode]
			public bool HasIsExtension
			{
				 get { } //Length: 15
			}

			[DebuggerNonUserCode]
			public bool HasNamePart_
			{
				 get { } //Length: 15
			}

			[DebuggerNonUserCode]
			public bool IsExtension
			{
				 get { } //Length: 79
				 set { } //Length: 18
			}

			[DebuggerNonUserCode]
			public string NamePart_
			{
				 get { } //Length: 75
				 set { } //Length: 83
			}

			[DebuggerNonUserCode]
			public static MessageParser<NamePart> Parser
			{
				 get { } //Length: 60
			}

			[DebuggerNonUserCode]
			private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
			{
				private get { } //Length: 154
			}

			private static NamePart() { }

			[DebuggerNonUserCode]
			public NamePart() { }

			[DebuggerNonUserCode]
			public NamePart(NamePart other) { }

			[DebuggerNonUserCode]
			public override int CalculateSize() { }

			[DebuggerNonUserCode]
			public void ClearIsExtension() { }

			[DebuggerNonUserCode]
			public void ClearNamePart_() { }

			[DebuggerNonUserCode]
			public override NamePart Clone() { }

			[DebuggerNonUserCode]
			public override bool Equals(NamePart other) { }

			[DebuggerNonUserCode]
			public virtual bool Equals(object other) { }

			public static MessageDescriptor get_Descriptor() { }

			public bool get_HasIsExtension() { }

			public bool get_HasNamePart_() { }

			public bool get_IsExtension() { }

			public string get_NamePart_() { }

			public static MessageParser<NamePart> get_Parser() { }

			[DebuggerNonUserCode]
			public virtual int GetHashCode() { }

			[DebuggerNonUserCode]
			public override void MergeFrom(NamePart other) { }

			[DebuggerNonUserCode]
			public override void MergeFrom(CodedInputStream input) { }

			private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

			public void set_IsExtension(bool value) { }

			public void set_NamePart_(string value) { }

			[DebuggerNonUserCode]
			public virtual string ToString() { }

			[DebuggerNonUserCode]
			public override void WriteTo(CodedOutputStream output) { }

		}


	}

	private static readonly MessageParser<UninterpretedOption> _parser; //Field offset: 0x0
	public const int DoubleValueFieldNumber = 6; //Field offset: 0x0
	public const int AggregateValueFieldNumber = 8; //Field offset: 0x0
	public const int NegativeIntValueFieldNumber = 5; //Field offset: 0x0
	public const int IdentifierValueFieldNumber = 3; //Field offset: 0x0
	public const int PositiveIntValueFieldNumber = 4; //Field offset: 0x0
	public const int NameFieldNumber = 2; //Field offset: 0x0
	public const int StringValueFieldNumber = 7; //Field offset: 0x0
	private static readonly FieldCodec<NamePart> _repeated_name_codec; //Field offset: 0x4
	private static readonly string IdentifierValueDefaultValue; //Field offset: 0x8
	private static readonly ulong PositiveIntValueDefaultValue; //Field offset: 0x10
	private static readonly long NegativeIntValueDefaultValue; //Field offset: 0x18
	private static readonly double DoubleValueDefaultValue; //Field offset: 0x20
	private static readonly ByteString StringValueDefaultValue; //Field offset: 0x28
	private static readonly string AggregateValueDefaultValue; //Field offset: 0x2C
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private int _hasBits0; //Field offset: 0xC
	private readonly RepeatedField<NamePart> name_; //Field offset: 0x10
	private string identifierValue_; //Field offset: 0x14
	private ulong positiveIntValue_; //Field offset: 0x18
	private long negativeIntValue_; //Field offset: 0x20
	private double doubleValue_; //Field offset: 0x28
	private ByteString stringValue_; //Field offset: 0x30
	private string aggregateValue_; //Field offset: 0x34

	[DebuggerNonUserCode]
	public string AggregateValue
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public double DoubleValue
	{
		 get { } //Length: 79
		 set { } //Length: 22
	}

	[DebuggerNonUserCode]
	public bool HasAggregateValue
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasDoubleValue
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasIdentifierValue
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasNegativeIntValue
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasPositiveIntValue
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasStringValue
	{
		 get { } //Length: 75
	}

	[DebuggerNonUserCode]
	public string IdentifierValue
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public RepeatedField<NamePart> Name
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public long NegativeIntValue
	{
		 get { } //Length: 87
		 set { } //Length: 24
	}

	[DebuggerNonUserCode]
	public static MessageParser<UninterpretedOption> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 60
	}

	[DebuggerNonUserCode]
	public ulong PositiveIntValue
	{
		 get { } //Length: 87
		 set { } //Length: 24
	}

	[DebuggerNonUserCode]
	public ByteString StringValue
	{
		 get { } //Length: 75
		 set { } //Length: 240
	}

	private static UninterpretedOption() { }

	[DebuggerNonUserCode]
	public UninterpretedOption() { }

	[DebuggerNonUserCode]
	public UninterpretedOption(UninterpretedOption other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public void ClearAggregateValue() { }

	[DebuggerNonUserCode]
	public void ClearDoubleValue() { }

	[DebuggerNonUserCode]
	public void ClearIdentifierValue() { }

	[DebuggerNonUserCode]
	public void ClearNegativeIntValue() { }

	[DebuggerNonUserCode]
	public void ClearPositiveIntValue() { }

	[DebuggerNonUserCode]
	public void ClearStringValue() { }

	[DebuggerNonUserCode]
	public override UninterpretedOption Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(UninterpretedOption other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public string get_AggregateValue() { }

	public static MessageDescriptor get_Descriptor() { }

	public double get_DoubleValue() { }

	public bool get_HasAggregateValue() { }

	public bool get_HasDoubleValue() { }

	public bool get_HasIdentifierValue() { }

	public bool get_HasNegativeIntValue() { }

	public bool get_HasPositiveIntValue() { }

	public bool get_HasStringValue() { }

	public string get_IdentifierValue() { }

	public RepeatedField<NamePart> get_Name() { }

	public long get_NegativeIntValue() { }

	public static MessageParser<UninterpretedOption> get_Parser() { }

	public ulong get_PositiveIntValue() { }

	public ByteString get_StringValue() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(UninterpretedOption other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_AggregateValue(string value) { }

	public void set_DoubleValue(double value) { }

	public void set_IdentifierValue(string value) { }

	public void set_NegativeIntValue(long value) { }

	public void set_PositiveIntValue(ulong value) { }

	public void set_StringValue(ByteString value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

