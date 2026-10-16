namespace Google.Protobuf.Reflection;

internal sealed class ServiceOptions : IMessage<ServiceOptions>, IMessage, IEquatable<ServiceOptions>, IDeepCloneable<ServiceOptions>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ServiceOptions <.cctor>b__39_0() { }

	}

	private static readonly MessageParser<ServiceOptions> _parser; //Field offset: 0x0
	public const int DeprecatedFieldNumber = 33; //Field offset: 0x0
	public const int UninterpretedOptionFieldNumber = 999; //Field offset: 0x0
	private static readonly bool DeprecatedDefaultValue; //Field offset: 0x4
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private int _hasBits0; //Field offset: 0xC
	[CompilerGenerated]
	private CustomOptions <CustomOptions>k__BackingField; //Field offset: 0x10
	private bool deprecated_; //Field offset: 0x14
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
	public static MessageParser<ServiceOptions> Parser
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

	private static ServiceOptions() { }

	[DebuggerNonUserCode]
	public ServiceOptions() { }

	[DebuggerNonUserCode]
	public ServiceOptions(ServiceOptions other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public void ClearDeprecated() { }

	[DebuggerNonUserCode]
	public override ServiceOptions Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(ServiceOptions other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[CompilerGenerated]
	internal CustomOptions get_CustomOptions() { }

	public bool get_Deprecated() { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_HasDeprecated() { }

	public static MessageParser<ServiceOptions> get_Parser() { }

	public RepeatedField<UninterpretedOption> get_UninterpretedOption() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(ServiceOptions other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[CompilerGenerated]
	private void set_CustomOptions(CustomOptions value) { }

	public void set_Deprecated(bool value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

