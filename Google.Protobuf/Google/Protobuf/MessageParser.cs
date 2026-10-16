namespace Google.Protobuf;

public class MessageParser
{
	private Func<IMessage> factory; //Field offset: 0x8
	[CompilerGenerated]
	private readonly bool <DiscardUnknownFields>k__BackingField; //Field offset: 0xC

	internal bool DiscardUnknownFields
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	internal MessageParser(Func<IMessage> factory, bool discardUnknownFields) { }

	internal static void CheckMergedRequiredFields(IMessage message) { }

	internal IMessage CreateTemplate() { }

	[CompilerGenerated]
	internal bool get_DiscardUnknownFields() { }

	internal void MergeFrom(IMessage message, CodedInputStream codedInput) { }

	public IMessage ParseDelimitedFrom(Stream input) { }

	public IMessage ParseFrom(Byte[] data) { }

	public IMessage ParseFrom(Byte[] data, int offset, int length) { }

	public IMessage ParseFrom(ByteString data) { }

	public IMessage ParseFrom(Stream input) { }

	public IMessage ParseFrom(CodedInputStream input) { }

	public IMessage ParseJson(string json) { }

	public MessageParser WithDiscardUnknownFields(bool discardUnknownFields) { }

}

