namespace Google.Protobuf;

public static class FieldCodec
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CodedInputStream, String> <>9__0_0; //Field offset: 0x4
		public static Action<CodedOutputStream, String> <>9__0_1; //Field offset: 0x8
		public static Func<CodedInputStream, ByteString> <>9__1_0; //Field offset: 0xC
		public static Action<CodedOutputStream, ByteString> <>9__1_1; //Field offset: 0x10
		public static Func<CodedInputStream, Boolean> <>9__2_0; //Field offset: 0x14
		public static Action<CodedOutputStream, Boolean> <>9__2_1; //Field offset: 0x18
		public static Func<CodedInputStream, Int32> <>9__3_0; //Field offset: 0x1C
		public static Action<CodedOutputStream, Int32> <>9__3_1; //Field offset: 0x20
		public static Func<CodedInputStream, Int32> <>9__4_0; //Field offset: 0x24
		public static Action<CodedOutputStream, Int32> <>9__4_1; //Field offset: 0x28
		public static Func<CodedInputStream, UInt32> <>9__5_0; //Field offset: 0x2C
		public static Action<CodedOutputStream, UInt32> <>9__5_1; //Field offset: 0x30
		public static Func<CodedInputStream, Int32> <>9__6_0; //Field offset: 0x34
		public static Action<CodedOutputStream, Int32> <>9__6_1; //Field offset: 0x38
		public static Func<CodedInputStream, UInt32> <>9__7_0; //Field offset: 0x3C
		public static Action<CodedOutputStream, UInt32> <>9__7_1; //Field offset: 0x40
		public static Func<CodedInputStream, Int64> <>9__8_0; //Field offset: 0x44
		public static Action<CodedOutputStream, Int64> <>9__8_1; //Field offset: 0x48
		public static Func<CodedInputStream, Int64> <>9__9_0; //Field offset: 0x4C
		public static Action<CodedOutputStream, Int64> <>9__9_1; //Field offset: 0x50
		public static Func<CodedInputStream, UInt64> <>9__10_0; //Field offset: 0x54
		public static Action<CodedOutputStream, UInt64> <>9__10_1; //Field offset: 0x58
		public static Func<CodedInputStream, Int64> <>9__11_0; //Field offset: 0x5C
		public static Action<CodedOutputStream, Int64> <>9__11_1; //Field offset: 0x60
		public static Func<CodedInputStream, UInt64> <>9__12_0; //Field offset: 0x64
		public static Action<CodedOutputStream, UInt64> <>9__12_1; //Field offset: 0x68
		public static Func<CodedInputStream, Single> <>9__13_0; //Field offset: 0x6C
		public static Action<CodedOutputStream, Single> <>9__13_1; //Field offset: 0x70
		public static Func<CodedInputStream, Double> <>9__14_0; //Field offset: 0x74
		public static Action<CodedOutputStream, Double> <>9__14_1; //Field offset: 0x78

		private static <>c() { }

		public <>c() { }

		internal bool <ForBool>b__2_0(CodedInputStream input) { }

		internal void <ForBool>b__2_1(CodedOutputStream output, bool value) { }

		internal ByteString <ForBytes>b__1_0(CodedInputStream input) { }

		internal void <ForBytes>b__1_1(CodedOutputStream output, ByteString value) { }

		internal double <ForDouble>b__14_0(CodedInputStream input) { }

		internal void <ForDouble>b__14_1(CodedOutputStream output, double value) { }

		internal uint <ForFixed32>b__5_0(CodedInputStream input) { }

		internal void <ForFixed32>b__5_1(CodedOutputStream output, uint value) { }

		internal ulong <ForFixed64>b__10_0(CodedInputStream input) { }

		internal void <ForFixed64>b__10_1(CodedOutputStream output, ulong value) { }

		internal float <ForFloat>b__13_0(CodedInputStream input) { }

		internal void <ForFloat>b__13_1(CodedOutputStream output, float value) { }

		internal int <ForInt32>b__3_0(CodedInputStream input) { }

		internal void <ForInt32>b__3_1(CodedOutputStream output, int value) { }

		internal long <ForInt64>b__8_0(CodedInputStream input) { }

		internal void <ForInt64>b__8_1(CodedOutputStream output, long value) { }

		internal int <ForSFixed32>b__6_0(CodedInputStream input) { }

		internal void <ForSFixed32>b__6_1(CodedOutputStream output, int value) { }

		internal long <ForSFixed64>b__11_0(CodedInputStream input) { }

		internal void <ForSFixed64>b__11_1(CodedOutputStream output, long value) { }

		internal int <ForSInt32>b__4_0(CodedInputStream input) { }

		internal void <ForSInt32>b__4_1(CodedOutputStream output, int value) { }

		internal long <ForSInt64>b__9_0(CodedInputStream input) { }

		internal void <ForSInt64>b__9_1(CodedOutputStream output, long value) { }

		internal string <ForString>b__0_0(CodedInputStream input) { }

		internal void <ForString>b__0_1(CodedOutputStream output, string value) { }

		internal uint <ForUInt32>b__7_0(CodedInputStream input) { }

		internal void <ForUInt32>b__7_1(CodedOutputStream output, uint value) { }

		internal ulong <ForUInt64>b__12_0(CodedInputStream input) { }

		internal void <ForUInt64>b__12_1(CodedOutputStream output, ulong value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__16
	{
		public static readonly <>c__16<T> <>9; //Field offset: 0x0
		public static Action<CodedOutputStream, T> <>9__16_1; //Field offset: 0x0
		public static Func<T, Int32> <>9__16_2; //Field offset: 0x0

		private static <>c__16`1() { }

		public <>c__16`1() { }

		internal void <ForMessage>b__16_1(CodedOutputStream output, T value) { }

		internal int <ForMessage>b__16_2(T message) { }

	}

	[CompilerGenerated]
	private sealed class <>c__17
	{
		public static readonly <>c__17<T> <>9; //Field offset: 0x0
		public static Action<CodedOutputStream, T> <>9__17_1; //Field offset: 0x0
		public static Func<T, Int32> <>9__17_2; //Field offset: 0x0

		private static <>c__17`1() { }

		public <>c__17`1() { }

		internal void <ForGroup>b__17_1(CodedOutputStream output, T value) { }

		internal int <ForGroup>b__17_2(T message) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public Func<Int32, T> fromInt32; //Field offset: 0x0
		public Func<T, Int32> toInt32; //Field offset: 0x0

		public <>c__DisplayClass15_0`1() { }

		internal T <ForEnum>b__0(CodedInputStream input) { }

		internal void <ForEnum>b__1(CodedOutputStream output, T value) { }

		internal int <ForEnum>b__2(T value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public MessageParser<T> parser; //Field offset: 0x0

		public <>c__DisplayClass16_0`1() { }

		internal T <ForMessage>b__0(CodedInputStream input) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public MessageParser<T> parser; //Field offset: 0x0

		public <>c__DisplayClass17_0`1() { }

		internal T <ForGroup>b__0(CodedInputStream input) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public FieldCodec<T> nestedCodec; //Field offset: 0x0

		public <>c__DisplayClass18_0`1() { }

		internal T <ForClassWrapper>b__0(CodedInputStream input) { }

		internal void <ForClassWrapper>b__1(CodedOutputStream output, T value) { }

		internal int <ForClassWrapper>b__2(T value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public FieldCodec<T> nestedCodec; //Field offset: 0x0

		public <>c__DisplayClass19_0`1() { }

		internal Nullable<T> <ForStructWrapper>b__0(CodedInputStream input) { }

		internal void <ForStructWrapper>b__1(CodedOutputStream output, Nullable<T> value) { }

		internal int <ForStructWrapper>b__2(Nullable<T> value) { }

	}

	private static class WrapperCodecs
	{
		private static readonly Dictionary<Type, Object> Codecs; //Field offset: 0x0

		private static WrapperCodecs() { }

		internal static int CalculateSize(T value, FieldCodec<T> codec) { }

		internal static FieldCodec<T> GetCodec() { }

		internal static T Read(CodedInputStream input, FieldCodec<T> codec) { }

		internal static void Write(CodedOutputStream output, T value, FieldCodec<T> codec) { }

	}


	public static FieldCodec<Boolean> ForBool(uint tag) { }

	public static FieldCodec<ByteString> ForBytes(uint tag) { }

	public static FieldCodec<T> ForClassWrapper(uint tag) { }

	public static FieldCodec<Double> ForDouble(uint tag) { }

	public static FieldCodec<T> ForEnum(uint tag, Func<T, Int32> toInt32, Func<Int32, T> fromInt32) { }

	public static FieldCodec<UInt32> ForFixed32(uint tag) { }

	public static FieldCodec<UInt64> ForFixed64(uint tag) { }

	public static FieldCodec<Single> ForFloat(uint tag) { }

	public static FieldCodec<T> ForGroup(uint startTag, uint endTag, MessageParser<T> parser) { }

	public static FieldCodec<Int32> ForInt32(uint tag) { }

	public static FieldCodec<Int64> ForInt64(uint tag) { }

	public static FieldCodec<T> ForMessage(uint tag, MessageParser<T> parser) { }

	public static FieldCodec<Int32> ForSFixed32(uint tag) { }

	public static FieldCodec<Int64> ForSFixed64(uint tag) { }

	public static FieldCodec<Int32> ForSInt32(uint tag) { }

	public static FieldCodec<Int64> ForSInt64(uint tag) { }

	public static FieldCodec<String> ForString(uint tag) { }

	public static FieldCodec<Nullable`1<T>> ForStructWrapper(uint tag) { }

	public static FieldCodec<UInt32> ForUInt32(uint tag) { }

	public static FieldCodec<UInt64> ForUInt64(uint tag) { }

}

