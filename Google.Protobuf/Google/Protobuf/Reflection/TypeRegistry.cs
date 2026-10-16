namespace Google.Protobuf.Reflection;

public sealed class TypeRegistry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MessageDescriptor, FileDescriptor> <>9__9_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal FileDescriptor <FromMessages>b__9_0(MessageDescriptor md) { }

	}

	private class Builder
	{
		private readonly Dictionary<String, MessageDescriptor> types; //Field offset: 0x8
		private readonly HashSet<String> fileDescriptorNames; //Field offset: 0xC

		internal Builder() { }

		internal void AddFile(FileDescriptor fileDescriptor) { }

		private void AddMessage(MessageDescriptor messageDescriptor) { }

		internal TypeRegistry Build() { }

	}

	[CompilerGenerated]
	private static readonly TypeRegistry <Empty>k__BackingField; //Field offset: 0x0
	private readonly Dictionary<String, MessageDescriptor> fullNameToMessageMap; //Field offset: 0x8

	public static TypeRegistry Empty
	{
		[CompilerGenerated]
		 get { } //Length: 60
	}

	private static TypeRegistry() { }

	private TypeRegistry(Dictionary<String, MessageDescriptor> fullNameToMessageMap) { }

	public MessageDescriptor Find(string fullName) { }

	public static TypeRegistry FromFiles(FileDescriptor[] fileDescriptors) { }

	public static TypeRegistry FromFiles(IEnumerable<FileDescriptor> fileDescriptors) { }

	public static TypeRegistry FromMessages(MessageDescriptor[] messageDescriptors) { }

	public static TypeRegistry FromMessages(IEnumerable<MessageDescriptor> messageDescriptors) { }

	[CompilerGenerated]
	public static TypeRegistry get_Empty() { }

}

