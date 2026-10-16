namespace System.CodeDom.Compiler;

[AttributeUsage(AttributeTargets::All (32767), Inherited = False, AllowMultiple = False)]
public sealed class GeneratedCodeAttribute : Attribute
{
	private readonly string tool; //Field offset: 0x8
	private readonly string version; //Field offset: 0xC

	public GeneratedCodeAttribute(string tool, string version) { }

}

