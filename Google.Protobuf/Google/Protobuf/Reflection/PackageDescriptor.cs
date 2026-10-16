namespace Google.Protobuf.Reflection;

internal sealed class PackageDescriptor : IDescriptor
{
	private readonly string name; //Field offset: 0x8
	private readonly string fullName; //Field offset: 0xC
	private readonly FileDescriptor file; //Field offset: 0x10

	public override FileDescriptor File
	{
		 get { } //Length: 11
	}

	public override string FullName
	{
		 get { } //Length: 11
	}

	public override string Name
	{
		 get { } //Length: 11
	}

	internal PackageDescriptor(string name, string fullName, FileDescriptor file) { }

	public override FileDescriptor get_File() { }

	public override string get_FullName() { }

	public override string get_Name() { }

}

