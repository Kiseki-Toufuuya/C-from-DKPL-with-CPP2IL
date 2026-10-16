namespace Google.Protobuf.Reflection;

internal sealed class EnumDescriptorProto : IMessage<EnumDescriptorProto>, IMessage, IEquatable<EnumDescriptorProto>, IDeepCloneable<EnumDescriptorProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal EnumDescriptorProto <.cctor>b__53_0() { }

	}

	[DebuggerNonUserCode]
	internal static class Types
	{
		public sealed class EnumReservedRange : IMessage<EnumReservedRange>, IMessage, IEquatable<EnumReservedRange>, IDeepCloneable<EnumReservedRange>
		{
			[CompilerGenerated]
			private sealed class <>c
			{
				public static readonly <>c <>9; //Field offset: 0x0

				private static <>c() { }

				public <>c() { }

				internal EnumReservedRange <.cctor>b__39_0() { }

			}

			private static readonly MessageParser<EnumReservedRange> _parser; //Field offset: 0x0
			public const int StartFieldNumber = 1; //Field offset: 0x0
			public const int EndFieldNumber = 2; //Field offset: 0x0
			private static readonly int StartDefaultValue; //Field offset: 0x4
			private static readonly int EndDefaultValue; //Field offset: 0x8
			private UnknownFieldSet _unknownFields; //Field offset: 0x8
			private int _hasBits0; //Field offset: 0xC
			private int start_; //Field offset: 0x10
			private int end_; //Field offset: 0x14

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				 get { } //Length: 105
			}

			[DebuggerNonUserCode]
			public int End
			{
				 get { } //Length: 79
				 set { } //Length: 18
			}

			[DebuggerNonUserCode]
			public bool HasEnd
			{
				 get { } //Length: 15
			}

			[DebuggerNonUserCode]
			public bool HasStart
			{
				 get { } //Length: 15
			}

			[DebuggerNonUserCode]
			public static MessageParser<EnumReservedRange> Parser
			{
				 get { } //Length: 60
			}

			[DebuggerNonUserCode]
			private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
			{
				private get { } //Length: 154
			}

			[DebuggerNonUserCode]
			public int Start
			{
				 get { } //Length: 79
				 set { } //Length: 18
			}

			private static EnumReservedRange() { }

			[DebuggerNonUserCode]
			public EnumReservedRange() { }

			[DebuggerNonUserCode]
			public EnumReservedRange(EnumReservedRange other) { }

			[DebuggerNonUserCode]
			public override int CalculateSize() { }

			[DebuggerNonUserCode]
			public void ClearEnd() { }

			[DebuggerNonUserCode]
			public void ClearStart() { }

			[DebuggerNonUserCode]
			public override EnumReservedRange Clone() { }

			[DebuggerNonUserCode]
			public override bool Equals(EnumReservedRange other) { }

			[DebuggerNonUserCode]
			public virtual bool Equals(object other) { }

			public static MessageDescriptor get_Descriptor() { }

			public int get_End() { }

			public bool get_HasEnd() { }

			public bool get_HasStart() { }

			public static MessageParser<EnumReservedRange> get_Parser() { }

			public int get_Start() { }

			[DebuggerNonUserCode]
			public virtual int GetHashCode() { }

			[DebuggerNonUserCode]
			public override void MergeFrom(EnumReservedRange other) { }

			[DebuggerNonUserCode]
			public override void MergeFrom(CodedInputStream input) { }

			private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

			public void set_End(int value) { }

			public void set_Start(int value) { }

			[DebuggerNonUserCode]
			public virtual string ToString() { }

			[DebuggerNonUserCode]
			public override void WriteTo(CodedOutputStream output) { }

		}


	}

	private static readonly MessageParser<EnumDescriptorProto> _parser; //Field offset: 0x0
	public const int NameFieldNumber = 1; //Field offset: 0x0
	public const int ValueFieldNumber = 2; //Field offset: 0x0
	public const int OptionsFieldNumber = 3; //Field offset: 0x0
	public const int ReservedRangeFieldNumber = 4; //Field offset: 0x0
	public const int ReservedNameFieldNumber = 5; //Field offset: 0x0
	private static readonly string NameDefaultValue; //Field offset: 0x4
	private static readonly FieldCodec<EnumValueDescriptorProto> _repeated_value_codec; //Field offset: 0x8
	private static readonly FieldCodec<EnumReservedRange> _repeated_reservedRange_codec; //Field offset: 0xC
	private static readonly FieldCodec<String> _repeated_reservedName_codec; //Field offset: 0x10
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private string name_; //Field offset: 0xC
	private readonly RepeatedField<EnumValueDescriptorProto> value_; //Field offset: 0x10
	private EnumOptions options_; //Field offset: 0x14
	private readonly RepeatedField<EnumReservedRange> reservedRange_; //Field offset: 0x18
	private readonly RepeatedField<String> reservedName_; //Field offset: 0x1C

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public bool HasName
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasOptions
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public string Name
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public EnumOptions Options
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[DebuggerNonUserCode]
	public static MessageParser<EnumDescriptorProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 60
	}

	[DebuggerNonUserCode]
	public RepeatedField<String> ReservedName
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<EnumReservedRange> ReservedRange
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<EnumValueDescriptorProto> Value
	{
		 get { } //Length: 11
	}

	private static EnumDescriptorProto() { }

	[DebuggerNonUserCode]
	public EnumDescriptorProto() { }

	[DebuggerNonUserCode]
	public EnumDescriptorProto(EnumDescriptorProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public void ClearName() { }

	[DebuggerNonUserCode]
	public void ClearOptions() { }

	[DebuggerNonUserCode]
	public override EnumDescriptorProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(EnumDescriptorProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_HasName() { }

	public bool get_HasOptions() { }

	public string get_Name() { }

	public EnumOptions get_Options() { }

	public static MessageParser<EnumDescriptorProto> get_Parser() { }

	public RepeatedField<String> get_ReservedName() { }

	public RepeatedField<EnumReservedRange> get_ReservedRange() { }

	public RepeatedField<EnumValueDescriptorProto> get_Value() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(EnumDescriptorProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Name(string value) { }

	public void set_Options(EnumOptions value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

