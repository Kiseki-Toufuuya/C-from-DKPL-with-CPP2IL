namespace Google.Protobuf;

[DefaultMember("Item")]
public sealed class ByteString : IEnumerable<Byte>, IEnumerable, IEquatable<ByteString>
{
	[CompilerGenerated]
	private struct <FromStreamAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ByteString> <>t__builder; //Field offset: 0x4
		public Stream stream; //Field offset: 0x10
		public CancellationToken cancellationToken; //Field offset: 0x14
		private MemoryStream <memoryStream>5__2; //Field offset: 0x18
		private TaskAwaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static class Unsafe
	{

		internal static ByteString FromBytes(Byte[] bytes) { }

	}

	private static readonly ByteString empty; //Field offset: 0x0
	private readonly Byte[] bytes; //Field offset: 0x8

	public static ByteString Empty
	{
		 get { } //Length: 60
	}

	public bool IsEmpty
	{
		 get { } //Length: 27
	}

	public byte Item
	{
		 get { } //Length: 36
	}

	public int Length
	{
		 get { } //Length: 23
	}

	private static ByteString() { }

	private ByteString(Byte[] bytes) { }

	internal static ByteString AttachBytes(Byte[] bytes) { }

	public static ByteString CopyFrom(Byte[] bytes) { }

	public static ByteString CopyFrom(Byte[] bytes, int offset, int count) { }

	public static ByteString CopyFrom(string text, Encoding encoding) { }

	public static ByteString CopyFromUtf8(string text) { }

	public void CopyTo(Byte[] array, int position) { }

	public CodedInputStream CreateCodedInput() { }

	public override bool Equals(ByteString other) { }

	public virtual bool Equals(object obj) { }

	public static ByteString FromBase64(string bytes) { }

	public static ByteString FromStream(Stream stream) { }

	[AsyncStateMachine(typeof(<FromStreamAsync>d__15))]
	public static Task<ByteString> FromStreamAsync(Stream stream, CancellationToken cancellationToken = null) { }

	public static ByteString get_Empty() { }

	public bool get_IsEmpty() { }

	public byte get_Item(int index) { }

	public int get_Length() { }

	public override IEnumerator<Byte> GetEnumerator() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(ByteString lhs, ByteString rhs) { }

	public static bool op_Inequality(ByteString lhs, ByteString rhs) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public string ToBase64() { }

	public Byte[] ToByteArray() { }

	public string ToString(Encoding encoding) { }

	public string ToStringUtf8() { }

	internal void WriteRawBytesTo(CodedOutputStream outputStream) { }

	public void WriteTo(Stream outputStream) { }

}

