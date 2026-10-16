namespace Google.Protobuf.Reflection;

internal sealed class DescriptorProto : IMessage<DescriptorProto>, IMessage, IEquatable<DescriptorProto>, IDeepCloneable<DescriptorProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal DescriptorProto <.cctor>b__78_0() { }

	}

	[DebuggerNonUserCode]
	internal static class Types
	{
		public sealed class ExtensionRange : IMessage<ExtensionRange>, IMessage, IEquatable<ExtensionRange>, IDeepCloneable<ExtensionRange>
		{
			[CompilerGenerated]
			private sealed class <>c
			{
				public static readonly <>c <>9; //Field offset: 0x0

				private static <>c() { }

				public <>c() { }

				internal ExtensionRange <.cctor>b__47_0() { }

			}

			private static readonly MessageParser<ExtensionRange> _parser; //Field offset: 0x0
			public const int StartFieldNumber = 1; //Field offset: 0x0
			public const int EndFieldNumber = 2; //Field offset: 0x0
			public const int OptionsFieldNumber = 3; //Field offset: 0x0
			private static readonly int StartDefaultValue; //Field offset: 0x4
			private static readonly int EndDefaultValue; //Field offset: 0x8
			private UnknownFieldSet _unknownFields; //Field offset: 0x8
			private int _hasBits0; //Field offset: 0xC
			private int start_; //Field offset: 0x10
			private int end_; //Field offset: 0x14
			private ExtensionRangeOptions options_; //Field offset: 0x18

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
			public bool HasOptions
			{
				 get { } //Length: 15
			}

			[DebuggerNonUserCode]
			public bool HasStart
			{
				 get { } //Length: 15
			}

			[DebuggerNonUserCode]
			public ExtensionRangeOptions Options
			{
				 get { } //Length: 11
				 set { } //Length: 27
			}

			[DebuggerNonUserCode]
			public static MessageParser<ExtensionRange> Parser
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

			private static ExtensionRange() { }

			[DebuggerNonUserCode]
			public ExtensionRange(ExtensionRange other) { }

			[DebuggerNonUserCode]
			public ExtensionRange() { }

			[DebuggerNonUserCode]
			public override int CalculateSize() { }

			[DebuggerNonUserCode]
			public void ClearEnd() { }

			[DebuggerNonUserCode]
			public void ClearOptions() { }

			[DebuggerNonUserCode]
			public void ClearStart() { }

			[DebuggerNonUserCode]
			public override ExtensionRange Clone() { }

			[DebuggerNonUserCode]
			public override bool Equals(ExtensionRange other) { }

			[DebuggerNonUserCode]
			public virtual bool Equals(object other) { }

			public static MessageDescriptor get_Descriptor() { }

			public int get_End() { }

			public bool get_HasEnd() { }

			public bool get_HasOptions() { }

			public bool get_HasStart() { }

			public ExtensionRangeOptions get_Options() { }

			public static MessageParser<ExtensionRange> get_Parser() { }

			public int get_Start() { }

			[DebuggerNonUserCode]
			public virtual int GetHashCode() { }

			[DebuggerNonUserCode]
			public override void MergeFrom(CodedInputStream input) { }

			[DebuggerNonUserCode]
			public override void MergeFrom(ExtensionRange other) { }

			private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

			public void set_End(int value) { }

			public void set_Options(ExtensionRangeOptions value) { }

			public void set_Start(int value) { }

			[DebuggerNonUserCode]
			public virtual string ToString() { }

			[DebuggerNonUserCode]
			public override void WriteTo(CodedOutputStream output) { }

		}

		public sealed class ReservedRange : IMessage<ReservedRange>, IMessage, IEquatable<ReservedRange>, IDeepCloneable<ReservedRange>
		{
			[CompilerGenerated]
			private sealed class <>c
			{
				public static readonly <>c <>9; //Field offset: 0x0

				private static <>c() { }

				public <>c() { }

				internal ReservedRange <.cctor>b__39_0() { }

			}

			private static readonly MessageParser<ReservedRange> _parser; //Field offset: 0x0
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
			public static MessageParser<ReservedRange> Parser
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

			private static ReservedRange() { }

			[DebuggerNonUserCode]
			public ReservedRange() { }

			[DebuggerNonUserCode]
			public ReservedRange(ReservedRange other) { }

			[DebuggerNonUserCode]
			public override int CalculateSize() { }

			[DebuggerNonUserCode]
			public void ClearEnd() { }

			[DebuggerNonUserCode]
			public void ClearStart() { }

			[DebuggerNonUserCode]
			public override ReservedRange Clone() { }

			[DebuggerNonUserCode]
			public override bool Equals(ReservedRange other) { }

			[DebuggerNonUserCode]
			public virtual bool Equals(object other) { }

			public static MessageDescriptor get_Descriptor() { }

			public int get_End() { }

			public bool get_HasEnd() { }

			public bool get_HasStart() { }

			public static MessageParser<ReservedRange> get_Parser() { }

			public int get_Start() { }

			[DebuggerNonUserCode]
			public virtual int GetHashCode() { }

			[DebuggerNonUserCode]
			public override void MergeFrom(ReservedRange other) { }

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

	private static readonly MessageParser<DescriptorProto> _parser; //Field offset: 0x0
	public const int ReservedNameFieldNumber = 10; //Field offset: 0x0
	public const int NameFieldNumber = 1; //Field offset: 0x0
	public const int ReservedRangeFieldNumber = 9; //Field offset: 0x0
	public const int FieldFieldNumber = 2; //Field offset: 0x0
	public const int OptionsFieldNumber = 7; //Field offset: 0x0
	public const int ExtensionFieldNumber = 6; //Field offset: 0x0
	public const int OneofDeclFieldNumber = 8; //Field offset: 0x0
	public const int NestedTypeFieldNumber = 3; //Field offset: 0x0
	public const int ExtensionRangeFieldNumber = 5; //Field offset: 0x0
	public const int EnumTypeFieldNumber = 4; //Field offset: 0x0
	private static readonly string NameDefaultValue; //Field offset: 0x4
	private static readonly FieldCodec<FieldDescriptorProto> _repeated_field_codec; //Field offset: 0x8
	private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec; //Field offset: 0xC
	private static readonly FieldCodec<DescriptorProto> _repeated_nestedType_codec; //Field offset: 0x10
	private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec; //Field offset: 0x14
	private static readonly FieldCodec<ExtensionRange> _repeated_extensionRange_codec; //Field offset: 0x18
	private static readonly FieldCodec<OneofDescriptorProto> _repeated_oneofDecl_codec; //Field offset: 0x1C
	private static readonly FieldCodec<ReservedRange> _repeated_reservedRange_codec; //Field offset: 0x20
	private static readonly FieldCodec<String> _repeated_reservedName_codec; //Field offset: 0x24
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private string name_; //Field offset: 0xC
	private readonly RepeatedField<FieldDescriptorProto> field_; //Field offset: 0x10
	private readonly RepeatedField<FieldDescriptorProto> extension_; //Field offset: 0x14
	private readonly RepeatedField<DescriptorProto> nestedType_; //Field offset: 0x18
	private readonly RepeatedField<EnumDescriptorProto> enumType_; //Field offset: 0x1C
	private readonly RepeatedField<ExtensionRange> extensionRange_; //Field offset: 0x20
	private readonly RepeatedField<OneofDescriptorProto> oneofDecl_; //Field offset: 0x24
	private MessageOptions options_; //Field offset: 0x28
	private readonly RepeatedField<ReservedRange> reservedRange_; //Field offset: 0x2C
	private readonly RepeatedField<String> reservedName_; //Field offset: 0x30

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public RepeatedField<EnumDescriptorProto> EnumType
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<FieldDescriptorProto> Extension
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<ExtensionRange> ExtensionRange
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<FieldDescriptorProto> Field
	{
		 get { } //Length: 11
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
	public RepeatedField<DescriptorProto> NestedType
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<OneofDescriptorProto> OneofDecl
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public MessageOptions Options
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[DebuggerNonUserCode]
	public static MessageParser<DescriptorProto> Parser
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
	public RepeatedField<ReservedRange> ReservedRange
	{
		 get { } //Length: 11
	}

	private static DescriptorProto() { }

	[DebuggerNonUserCode]
	public DescriptorProto() { }

	[DebuggerNonUserCode]
	public DescriptorProto(DescriptorProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public void ClearName() { }

	[DebuggerNonUserCode]
	public void ClearOptions() { }

	[DebuggerNonUserCode]
	public override DescriptorProto Clone() { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[DebuggerNonUserCode]
	public override bool Equals(DescriptorProto other) { }

	public static MessageDescriptor get_Descriptor() { }

	public RepeatedField<EnumDescriptorProto> get_EnumType() { }

	public RepeatedField<FieldDescriptorProto> get_Extension() { }

	public RepeatedField<ExtensionRange> get_ExtensionRange() { }

	public RepeatedField<FieldDescriptorProto> get_Field() { }

	public bool get_HasName() { }

	public bool get_HasOptions() { }

	public string get_Name() { }

	public RepeatedField<DescriptorProto> get_NestedType() { }

	public RepeatedField<OneofDescriptorProto> get_OneofDecl() { }

	public MessageOptions get_Options() { }

	public static MessageParser<DescriptorProto> get_Parser() { }

	public RepeatedField<String> get_ReservedName() { }

	public RepeatedField<ReservedRange> get_ReservedRange() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(DescriptorProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Name(string value) { }

	public void set_Options(MessageOptions value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

