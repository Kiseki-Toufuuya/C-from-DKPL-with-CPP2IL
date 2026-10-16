namespace Google.Protobuf.Reflection;

internal sealed class DescriptorPool
{
	private struct DescriptorIntPair : IEquatable<DescriptorIntPair>
	{
		private readonly int number; //Field offset: 0x0
		private readonly IDescriptor descriptor; //Field offset: 0x4

		internal DescriptorIntPair(IDescriptor descriptor, int number) { }

		public override bool Equals(DescriptorIntPair other) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

	}

	private static readonly Regex ValidationRegex; //Field offset: 0x0
	private readonly IDictionary<String, IDescriptor> descriptorsByName; //Field offset: 0x8
	private readonly IDictionary<DescriptorIntPair, FieldDescriptor> fieldsByNumber; //Field offset: 0xC
	private readonly IDictionary<DescriptorIntPair, EnumValueDescriptor> enumValuesByNumber; //Field offset: 0x10
	private readonly HashSet<FileDescriptor> dependencies; //Field offset: 0x14

	private static DescriptorPool() { }

	internal DescriptorPool(IEnumerable<FileDescriptor> dependencyFiles) { }

	internal void AddEnumValueByNumber(EnumValueDescriptor enumValue) { }

	internal void AddFieldByNumber(FieldDescriptor field) { }

	internal void AddPackage(string fullName, FileDescriptor file) { }

	internal void AddSymbol(IDescriptor descriptor) { }

	internal EnumValueDescriptor FindEnumValueByNumber(EnumDescriptor enumDescriptor, int number) { }

	internal FieldDescriptor FindFieldByNumber(MessageDescriptor messageDescriptor, int number) { }

	internal T FindSymbol(string fullName) { }

	private void ImportPublicDependencies(FileDescriptor file) { }

	internal IDescriptor LookupSymbol(string name, IDescriptor relativeTo) { }

	private static void ValidateSymbolName(IDescriptor descriptor) { }

}

