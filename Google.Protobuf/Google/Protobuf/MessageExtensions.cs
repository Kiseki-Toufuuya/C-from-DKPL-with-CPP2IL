namespace Google.Protobuf;

[Extension]
public static class MessageExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public IMessage message; //Field offset: 0x8

		public <>c__DisplayClass9_0() { }

		internal bool <IsInitialized>b__0(FieldDescriptor f) { }

	}


	[Extension]
	public static bool IsInitialized(IMessage message) { }

	[Extension]
	public static void MergeDelimitedFrom(IMessage message, Stream input) { }

	[Extension]
	internal static void MergeDelimitedFrom(IMessage message, Stream input, bool discardUnknownFields) { }

	[Extension]
	public static void MergeFrom(IMessage message, Byte[] data) { }

	[Extension]
	public static void MergeFrom(IMessage message, Byte[] data, int offset, int length) { }

	[Extension]
	public static void MergeFrom(IMessage message, ByteString data) { }

	[Extension]
	public static void MergeFrom(IMessage message, Stream input) { }

	[Extension]
	internal static void MergeFrom(IMessage message, Byte[] data, bool discardUnknownFields) { }

	[Extension]
	internal static void MergeFrom(IMessage message, Byte[] data, int offset, int length, bool discardUnknownFields) { }

	[Extension]
	internal static void MergeFrom(IMessage message, ByteString data, bool discardUnknownFields) { }

	[Extension]
	internal static void MergeFrom(IMessage message, Stream input, bool discardUnknownFields) { }

	[Extension]
	public static Byte[] ToByteArray(IMessage message) { }

	[Extension]
	public static ByteString ToByteString(IMessage message) { }

	[Extension]
	public static void WriteDelimitedTo(IMessage message, Stream output) { }

	[Extension]
	public static void WriteTo(IMessage message, Stream output) { }

}

