namespace Google.Protobuf.WellKnownTypes;

public sealed class FieldMask : IMessage<FieldMask>, IMessage, IEquatable<FieldMask>, IDeepCloneable<FieldMask>, ICustomDiagnosticMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Boolean> <>9__27_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal FieldMask <.cctor>b__45_0() { }

		internal bool <ToJson>b__27_0(string p) { }

	}

	internal sealed class MergeOptions
	{
		[CompilerGenerated]
		private bool <ReplaceMessageFields>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private bool <ReplaceRepeatedFields>k__BackingField; //Field offset: 0x9
		[CompilerGenerated]
		private bool <ReplacePrimitiveFields>k__BackingField; //Field offset: 0xA

		public bool ReplaceMessageFields
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public bool ReplacePrimitiveFields
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public bool ReplaceRepeatedFields
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public MergeOptions() { }

		[CompilerGenerated]
		public bool get_ReplaceMessageFields() { }

		[CompilerGenerated]
		public bool get_ReplacePrimitiveFields() { }

		[CompilerGenerated]
		public bool get_ReplaceRepeatedFields() { }

		[CompilerGenerated]
		public void set_ReplaceMessageFields(bool value) { }

		[CompilerGenerated]
		public void set_ReplacePrimitiveFields(bool value) { }

		[CompilerGenerated]
		public void set_ReplaceRepeatedFields(bool value) { }

	}

	private static readonly MessageParser<FieldMask> _parser; //Field offset: 0x0
	public const int PathsFieldNumber = 1; //Field offset: 0x0
	private const char FIELD_PATH_SEPARATOR = '\u2C'; //Field offset: 0x0
	private const char FIELD_SEPARATOR_REGEX = '\u2E'; //Field offset: 0x0
	private static readonly FieldCodec<String> _repeated_paths_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private readonly RepeatedField<String> paths_; //Field offset: 0xC

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public static MessageParser<FieldMask> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	public RepeatedField<String> Paths
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static FieldMask() { }

	[DebuggerNonUserCode]
	public FieldMask() { }

	[DebuggerNonUserCode]
	public FieldMask(FieldMask other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override FieldMask Clone() { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[DebuggerNonUserCode]
	public override bool Equals(FieldMask other) { }

	public static FieldMask FromFieldNumbers(IEnumerable<Int32> fieldNumbers) { }

	public static FieldMask FromFieldNumbers(Int32[] fieldNumbers) { }

	public static FieldMask FromString(string value) { }

	public static FieldMask FromString(string value) { }

	public static FieldMask FromStringEnumerable(IEnumerable<String> paths) { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<FieldMask> get_Parser() { }

	public RepeatedField<String> get_Paths() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	public FieldMask Intersection(FieldMask additionalMask) { }

	private static bool IsPathValid(string input) { }

	public static bool IsValid(FieldMask fieldMask) { }

	public static bool IsValid(MessageDescriptor descriptor, string path) { }

	public static bool IsValid(string path) { }

	public static bool IsValid(MessageDescriptor descriptor, FieldMask fieldMask) { }

	public void Merge(IMessage source, IMessage destination, MergeOptions options) { }

	public void Merge(IMessage source, IMessage destination) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(FieldMask other) { }

	public FieldMask Normalize() { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public override string ToDiagnosticString() { }

	internal static string ToJson(IList<String> paths, bool diagnosticOnly) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	public FieldMask Union(FieldMask[] otherMasks) { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

