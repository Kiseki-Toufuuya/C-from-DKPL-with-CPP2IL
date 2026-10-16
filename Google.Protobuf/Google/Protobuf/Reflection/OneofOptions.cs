namespace Google.Protobuf.Reflection;

internal sealed class OneofOptions : IMessage<OneofOptions>, IMessage, IEquatable<OneofOptions>, IDeepCloneable<OneofOptions>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal OneofOptions <.cctor>b__29_0() { }

	}

	private static readonly MessageParser<OneofOptions> _parser; //Field offset: 0x0
	public const int UninterpretedOptionFieldNumber = 999; //Field offset: 0x0
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	[CompilerGenerated]
	private CustomOptions <CustomOptions>k__BackingField; //Field offset: 0xC
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; //Field offset: 0x10

	internal CustomOptions CustomOptions
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public static MessageParser<OneofOptions> Parser
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

	private static OneofOptions() { }

	[DebuggerNonUserCode]
	public OneofOptions() { }

	[DebuggerNonUserCode]
	public OneofOptions(OneofOptions other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override OneofOptions Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(OneofOptions other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[CompilerGenerated]
	internal CustomOptions get_CustomOptions() { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<OneofOptions> get_Parser() { }

	public RepeatedField<UninterpretedOption> get_UninterpretedOption() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(OneofOptions other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[CompilerGenerated]
	private void set_CustomOptions(CustomOptions value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

