namespace Google.Protobuf.Reflection;

public sealed class CustomOptions
{
	private struct FieldValue
	{
		[CompilerGenerated]
		private readonly ulong <Number>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly ByteString <ByteString>k__BackingField; //Field offset: 0x8

		internal ByteString ByteString
		{
			[CompilerGenerated]
			internal get { } //Length: 11
		}

		internal ulong Number
		{
			[CompilerGenerated]
			internal get { } //Length: 13
		}

		internal FieldValue(ulong number) { }

		internal FieldValue(ByteString byteString) { }

		[CompilerGenerated]
		internal ByteString get_ByteString() { }

		[CompilerGenerated]
		internal ulong get_Number() { }

	}

	internal static readonly CustomOptions Empty; //Field offset: 0x0
	private readonly Dictionary<Int32, List`1<FieldValue>> valuesByField; //Field offset: 0x8

	private static CustomOptions() { }

	private CustomOptions() { }

	private CustomOptions AddValue(int field, FieldValue value) { }

	private ByteString GetLastByteStringValue(int field) { }

	private Nullable<UInt64> GetLastNumericValue(int field) { }

	internal CustomOptions ReadOrSkipUnknownField(CodedInputStream input) { }

	public bool TryGetBool(int field, out bool value) { }

	public bool TryGetBytes(int field, out ByteString value) { }

	public bool TryGetDouble(int field, out double value) { }

	public bool TryGetFixed32(int field, out uint value) { }

	public bool TryGetFixed64(int field, out ulong value) { }

	public bool TryGetFloat(int field, out float value) { }

	public bool TryGetInt32(int field, out int value) { }

	public bool TryGetInt64(int field, out long value) { }

	public bool TryGetMessage(int field, out T value) { }

	public bool TryGetSFixed32(int field, out int value) { }

	public bool TryGetSFixed64(int field, out long value) { }

	public bool TryGetSInt32(int field, out int value) { }

	public bool TryGetSInt64(int field, out long value) { }

	public bool TryGetString(int field, out string value) { }

	public bool TryGetUInt32(int field, out uint value) { }

	public bool TryGetUInt64(int field, out ulong value) { }

}

