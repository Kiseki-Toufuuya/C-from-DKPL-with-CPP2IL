namespace Google.Protobuf.Reflection;

internal sealed class FieldOptions : IMessage<FieldOptions>, IMessage, IEquatable<FieldOptions>, IDeepCloneable<FieldOptions>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal FieldOptions <.cctor>b__85_0() { }

	}

	[DebuggerNonUserCode]
	internal static class Types
	{
		public enum CType
		{
			String = 0,
			Cord = 1,
			StringPiece = 2,
		}

		public enum JSType
		{
			JsNormal = 0,
			JsString = 1,
			JsNumber = 2,
		}


	}

	private static readonly MessageParser<FieldOptions> _parser; //Field offset: 0x0
	public const int DeprecatedFieldNumber = 3; //Field offset: 0x0
	public const int UninterpretedOptionFieldNumber = 999; //Field offset: 0x0
	public const int LazyFieldNumber = 5; //Field offset: 0x0
	public const int JstypeFieldNumber = 6; //Field offset: 0x0
	public const int PackedFieldNumber = 2; //Field offset: 0x0
	public const int WeakFieldNumber = 10; //Field offset: 0x0
	public const int CtypeFieldNumber = 1; //Field offset: 0x0
	private static readonly CType CtypeDefaultValue; //Field offset: 0x4
	private static readonly bool PackedDefaultValue; //Field offset: 0x8
	private static readonly JSType JstypeDefaultValue; //Field offset: 0xC
	private static readonly bool LazyDefaultValue; //Field offset: 0x10
	private static readonly bool DeprecatedDefaultValue; //Field offset: 0x11
	private static readonly bool WeakDefaultValue; //Field offset: 0x12
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; //Field offset: 0x14
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private int _hasBits0; //Field offset: 0xC
	[CompilerGenerated]
	private CustomOptions <CustomOptions>k__BackingField; //Field offset: 0x10
	private CType ctype_; //Field offset: 0x14
	private bool packed_; //Field offset: 0x18
	private JSType jstype_; //Field offset: 0x1C
	private bool lazy_; //Field offset: 0x20
	private bool deprecated_; //Field offset: 0x21
	private bool weak_; //Field offset: 0x22
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; //Field offset: 0x24

	[DebuggerNonUserCode]
	public CType Ctype
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

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
	public bool HasCtype
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasDeprecated
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasJstype
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasLazy
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasPacked
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasWeak
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public JSType Jstype
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public bool Lazy
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public bool Packed
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public static MessageParser<FieldOptions> Parser
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

	[DebuggerNonUserCode]
	public bool Weak
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	private static FieldOptions() { }

	[DebuggerNonUserCode]
	public FieldOptions(FieldOptions other) { }

	[DebuggerNonUserCode]
	public FieldOptions() { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public void ClearCtype() { }

	[DebuggerNonUserCode]
	public void ClearDeprecated() { }

	[DebuggerNonUserCode]
	public void ClearJstype() { }

	[DebuggerNonUserCode]
	public void ClearLazy() { }

	[DebuggerNonUserCode]
	public void ClearPacked() { }

	[DebuggerNonUserCode]
	public void ClearWeak() { }

	[DebuggerNonUserCode]
	public override FieldOptions Clone() { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[DebuggerNonUserCode]
	public override bool Equals(FieldOptions other) { }

	public CType get_Ctype() { }

	[CompilerGenerated]
	internal CustomOptions get_CustomOptions() { }

	public bool get_Deprecated() { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_HasCtype() { }

	public bool get_HasDeprecated() { }

	public bool get_HasJstype() { }

	public bool get_HasLazy() { }

	public bool get_HasPacked() { }

	public bool get_HasWeak() { }

	public JSType get_Jstype() { }

	public bool get_Lazy() { }

	public bool get_Packed() { }

	public static MessageParser<FieldOptions> get_Parser() { }

	public RepeatedField<UninterpretedOption> get_UninterpretedOption() { }

	public bool get_Weak() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(FieldOptions other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Ctype(CType value) { }

	[CompilerGenerated]
	private void set_CustomOptions(CustomOptions value) { }

	public void set_Deprecated(bool value) { }

	public void set_Jstype(JSType value) { }

	public void set_Lazy(bool value) { }

	public void set_Packed(bool value) { }

	public void set_Weak(bool value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

