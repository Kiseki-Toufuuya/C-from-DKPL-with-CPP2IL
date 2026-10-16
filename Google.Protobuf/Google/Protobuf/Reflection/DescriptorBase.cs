namespace Google.Protobuf.Reflection;

public abstract class DescriptorBase : IDescriptor
{
	[CompilerGenerated]
	private readonly int <Index>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly string <FullName>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private readonly FileDescriptor <File>k__BackingField; //Field offset: 0x10

	public DescriptorDeclaration Declaration
	{
		 get { } //Length: 119
	}

	public override FileDescriptor File
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public override string FullName
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public int Index
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public abstract string Name
	{
		 get { } //Length: 0
	}

	internal DescriptorBase(FileDescriptor file, string fullName, int index) { }

	public DescriptorDeclaration get_Declaration() { }

	[CompilerGenerated]
	public override FileDescriptor get_File() { }

	[CompilerGenerated]
	public override string get_FullName() { }

	[CompilerGenerated]
	public int get_Index() { }

	public abstract string get_Name() { }

	internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) { }

}

