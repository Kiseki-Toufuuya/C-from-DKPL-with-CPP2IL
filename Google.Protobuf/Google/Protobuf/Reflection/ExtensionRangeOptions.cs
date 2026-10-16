namespace Google.Protobuf.Reflection;

internal sealed class ExtensionRangeOptions : IMessage<ExtensionRangeOptions>, IMessage, IEquatable<ExtensionRangeOptions>, IDeepCloneable<ExtensionRangeOptions>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ExtensionRangeOptions <.cctor>b__25_0() { }

	}

	private static readonly MessageParser<ExtensionRangeOptions> _parser; //Field offset: 0x0
	public const int UninterpretedOptionFieldNumber = 999; //Field offset: 0x0
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; //Field offset: 0xC

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public static MessageParser<ExtensionRangeOptions> Parser
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

	private static ExtensionRangeOptions() { }

	[DebuggerNonUserCode]
	public ExtensionRangeOptions() { }

	[DebuggerNonUserCode]
	public ExtensionRangeOptions(ExtensionRangeOptions other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override ExtensionRangeOptions Clone() { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[DebuggerNonUserCode]
	public override bool Equals(ExtensionRangeOptions other) { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<ExtensionRangeOptions> get_Parser() { }

	public RepeatedField<UninterpretedOption> get_UninterpretedOption() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(ExtensionRangeOptions other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

