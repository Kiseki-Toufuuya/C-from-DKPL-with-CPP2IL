namespace Google.Protobuf.Reflection;

public sealed class DescriptorDeclaration
{
	[CompilerGenerated]
	private readonly IDescriptor <Descriptor>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly int <StartLine>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private readonly int <StartColumn>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <EndLine>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly int <EndColumn>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <LeadingComments>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private readonly string <TrailingComments>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly IReadOnlyList<String> <LeadingDetachedComments>k__BackingField; //Field offset: 0x24

	public IDescriptor Descriptor
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public int EndColumn
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public int EndLine
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public string LeadingComments
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public IReadOnlyList<String> LeadingDetachedComments
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public int StartColumn
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public int StartLine
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public string TrailingComments
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	private DescriptorDeclaration(IDescriptor descriptor, Location location) { }

	internal static DescriptorDeclaration FromProto(IDescriptor descriptor, Location location) { }

	[CompilerGenerated]
	public IDescriptor get_Descriptor() { }

	[CompilerGenerated]
	public int get_EndColumn() { }

	[CompilerGenerated]
	public int get_EndLine() { }

	[CompilerGenerated]
	public string get_LeadingComments() { }

	[CompilerGenerated]
	public IReadOnlyList<String> get_LeadingDetachedComments() { }

	[CompilerGenerated]
	public int get_StartColumn() { }

	[CompilerGenerated]
	public int get_StartLine() { }

	[CompilerGenerated]
	public string get_TrailingComments() { }

}

