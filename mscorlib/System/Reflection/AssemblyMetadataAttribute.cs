namespace System.Reflection;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True, Inherited = False)]
public sealed class AssemblyMetadataAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <Key>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly string <Value>k__BackingField; //Field offset: 0xC

	public AssemblyMetadataAttribute(string key, string value) { }

}

