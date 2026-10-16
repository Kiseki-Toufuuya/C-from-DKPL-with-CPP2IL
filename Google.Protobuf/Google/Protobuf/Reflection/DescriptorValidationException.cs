namespace Google.Protobuf.Reflection;

public sealed class DescriptorValidationException : Exception
{
	private readonly string name; //Field offset: 0x48
	private readonly string description; //Field offset: 0x4C

	public string Description
	{
		 get { } //Length: 11
	}

	public string ProblemSymbolName
	{
		 get { } //Length: 11
	}

	internal DescriptorValidationException(IDescriptor problemDescriptor, string description) { }

	internal DescriptorValidationException(IDescriptor problemDescriptor, string description, Exception cause) { }

	public string get_Description() { }

	public string get_ProblemSymbolName() { }

}

