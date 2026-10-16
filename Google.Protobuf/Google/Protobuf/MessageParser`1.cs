namespace Google.Protobuf;

public sealed class MessageParser : MessageParser
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Func<T> factory; //Field offset: 0x0

		public <>c__DisplayClass2_0() { }

		internal IMessage <.ctor>b__0() { }

	}

	private readonly Func<T> factory; //Field offset: 0x0

	public MessageParser`1(Func<T> factory) { }

	internal MessageParser`1(Func<T> factory, bool discardUnknownFields) { }

	internal T CreateTemplate() { }

	public T ParseDelimitedFrom(Stream input) { }

	public T ParseFrom(Byte[] data) { }

	public T ParseFrom(Byte[] data, int offset, int length) { }

	public T ParseFrom(ByteString data) { }

	public T ParseFrom(Stream input) { }

	public T ParseFrom(CodedInputStream input) { }

	public T ParseJson(string json) { }

	public MessageParser<T> WithDiscardUnknownFields(bool discardUnknownFields) { }

}

