namespace Google.Protobuf.Reflection;

internal sealed class EnumValueDescriptorProto : IMessage<EnumValueDescriptorProto>, IMessage, IEquatable<EnumValueDescriptorProto>, IDeepCloneable<EnumValueDescriptorProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal EnumValueDescriptorProto <.cctor>b__47_0() { }

	}

	private static readonly MessageParser<EnumValueDescriptorProto> _parser; //Field offset: 0x0
	public const int NameFieldNumber = 1; //Field offset: 0x0
	public const int NumberFieldNumber = 2; //Field offset: 0x0
	public const int OptionsFieldNumber = 3; //Field offset: 0x0
	private static readonly string NameDefaultValue; //Field offset: 0x4
	private static readonly int NumberDefaultValue; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private int _hasBits0; //Field offset: 0xC
	private string name_; //Field offset: 0x10
	private int number_; //Field offset: 0x14
	private EnumValueOptions options_; //Field offset: 0x18

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
	public bool HasNumber
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
	public int Number
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public EnumValueOptions Options
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[DebuggerNonUserCode]
	public static MessageParser<EnumValueDescriptorProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static EnumValueDescriptorProto() { }

	[DebuggerNonUserCode]
	public EnumValueDescriptorProto() { }

	[DebuggerNonUserCode]
	public EnumValueDescriptorProto(EnumValueDescriptorProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public void ClearName() { }

	[DebuggerNonUserCode]
	public void ClearNumber() { }

	[DebuggerNonUserCode]
	public void ClearOptions() { }

	[DebuggerNonUserCode]
	public override EnumValueDescriptorProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(EnumValueDescriptorProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_HasName() { }

	public bool get_HasNumber() { }

	public bool get_HasOptions() { }

	public string get_Name() { }

	public int get_Number() { }

	public EnumValueOptions get_Options() { }

	public static MessageParser<EnumValueDescriptorProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(EnumValueDescriptorProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Name(string value) { }

	public void set_Number(int value) { }

	public void set_Options(EnumValueOptions value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

