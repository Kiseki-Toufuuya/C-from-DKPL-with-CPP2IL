namespace Google.Protobuf.Reflection;

internal sealed class MessageOptions : IMessage<MessageOptions>, IMessage, IEquatable<MessageOptions>, IDeepCloneable<MessageOptions>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal MessageOptions <.cctor>b__66_0() { }

	}

	private static readonly MessageParser<MessageOptions> _parser; //Field offset: 0x0
	public const int MessageSetWireFormatFieldNumber = 1; //Field offset: 0x0
	public const int NoStandardDescriptorAccessorFieldNumber = 2; //Field offset: 0x0
	public const int DeprecatedFieldNumber = 3; //Field offset: 0x0
	public const int UninterpretedOptionFieldNumber = 999; //Field offset: 0x0
	public const int MapEntryFieldNumber = 7; //Field offset: 0x0
	private static readonly bool MessageSetWireFormatDefaultValue; //Field offset: 0x4
	private static readonly bool NoStandardDescriptorAccessorDefaultValue; //Field offset: 0x5
	private static readonly bool DeprecatedDefaultValue; //Field offset: 0x6
	private static readonly bool MapEntryDefaultValue; //Field offset: 0x7
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private int _hasBits0; //Field offset: 0xC
	[CompilerGenerated]
	private CustomOptions <CustomOptions>k__BackingField; //Field offset: 0x10
	private bool messageSetWireFormat_; //Field offset: 0x14
	private bool noStandardDescriptorAccessor_; //Field offset: 0x15
	private bool deprecated_; //Field offset: 0x16
	private bool mapEntry_; //Field offset: 0x17
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; //Field offset: 0x18

	internal CustomOptions CustomOptions
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	[DebuggerNonUserCode]
	public bool Deprecated
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public bool HasDeprecated
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasMapEntry
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasMessageSetWireFormat
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasNoStandardDescriptorAccessor
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool MapEntry
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public bool MessageSetWireFormat
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public bool NoStandardDescriptorAccessor
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public static MessageParser<MessageOptions> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public RepeatedField<UninterpretedOption> UninterpretedOption
	{
		 get { } //Length: 11
	}

	private static MessageOptions() { }

	[DebuggerNonUserCode]
	public MessageOptions() { }

	[DebuggerNonUserCode]
	public MessageOptions(MessageOptions other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public void ClearDeprecated() { }

	[DebuggerNonUserCode]
	public void ClearMapEntry() { }

	[DebuggerNonUserCode]
	public void ClearMessageSetWireFormat() { }

	[DebuggerNonUserCode]
	public void ClearNoStandardDescriptorAccessor() { }

	[DebuggerNonUserCode]
	public override MessageOptions Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(MessageOptions other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[CompilerGenerated]
	internal CustomOptions get_CustomOptions() { }

	public bool get_Deprecated() { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_HasDeprecated() { }

	public bool get_HasMapEntry() { }

	public bool get_HasMessageSetWireFormat() { }

	public bool get_HasNoStandardDescriptorAccessor() { }

	public bool get_MapEntry() { }

	public bool get_MessageSetWireFormat() { }

	public bool get_NoStandardDescriptorAccessor() { }

	public static MessageParser<MessageOptions> get_Parser() { }

	public RepeatedField<UninterpretedOption> get_UninterpretedOption() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(MessageOptions other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[CompilerGenerated]
	private void set_CustomOptions(CustomOptions value) { }

	public void set_Deprecated(bool value) { }

	public void set_MapEntry(bool value) { }

	public void set_MessageSetWireFormat(bool value) { }

	public void set_NoStandardDescriptorAccessor(bool value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

