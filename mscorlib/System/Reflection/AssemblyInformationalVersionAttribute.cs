namespace System.Reflection;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False)]
public sealed class AssemblyInformationalVersionAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <InformationalVersion>k__BackingField; //Field offset: 0x8

	public AssemblyInformationalVersionAttribute(string informationalVersion) { }

}

