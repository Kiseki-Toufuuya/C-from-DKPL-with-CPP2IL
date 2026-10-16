namespace Google.Protobuf;

public sealed class FieldCodec
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public int fixedSize; //Field offset: 0x0

		public <>c__DisplayClass30_0() { }

		internal int <.ctor>b__0(T _) { }

	}

	private static readonly EqualityComparer<T> EqualityComparer; //Field offset: 0x0
	private static readonly T DefaultDefault; //Field offset: 0x0
	private static readonly bool TypeSupportsPacking; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <PackedRepeatedField>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Action<CodedOutputStream, T> <ValueWriter>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Func<T, Int32> <ValueSizeCalculator>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Func<CodedInputStream, T> <ValueReader>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly int <FixedSize>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly uint <Tag>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly uint <EndTag>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly T <DefaultValue>k__BackingField; //Field offset: 0x0
	private readonly int tagSize; //Field offset: 0x0

	internal T DefaultValue
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	internal uint EndTag
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	internal int FixedSize
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	internal bool PackedRepeatedField
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	internal uint Tag
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	internal Func<CodedInputStream, T> ValueReader
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	internal Func<T, Int32> ValueSizeCalculator
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	internal Action<CodedOutputStream, T> ValueWriter
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	private static FieldCodec`1() { }

	internal FieldCodec`1(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, Func<T, Int32> sizeCalculator, uint tag, uint endTag, T defaultValue) { }

	internal FieldCodec`1(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, Func<T, Int32> sizeCalculator, uint tag, uint endTag = 0) { }

	internal FieldCodec`1(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, int fixedSize, uint tag) { }

	public int CalculateSizeWithTag(T value) { }

	[CompilerGenerated]
	internal T get_DefaultValue() { }

	[CompilerGenerated]
	internal uint get_EndTag() { }

	[CompilerGenerated]
	internal int get_FixedSize() { }

	[CompilerGenerated]
	internal bool get_PackedRepeatedField() { }

	[CompilerGenerated]
	internal uint get_Tag() { }

	[CompilerGenerated]
	internal Func<CodedInputStream, T> get_ValueReader() { }

	[CompilerGenerated]
	internal Func<T, Int32> get_ValueSizeCalculator() { }

	[CompilerGenerated]
	internal Action<CodedOutputStream, T> get_ValueWriter() { }

	private bool IsDefault(T value) { }

	internal static bool IsPackedRepeatedField(uint tag) { }

	public T Read(CodedInputStream input) { }

	public void WriteTagAndValue(CodedOutputStream output, T value) { }

}

