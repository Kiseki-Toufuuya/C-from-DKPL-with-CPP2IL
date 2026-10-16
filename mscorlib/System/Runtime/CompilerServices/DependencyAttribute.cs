namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True)]
public sealed class DependencyAttribute : Attribute
{
	private string dependentAssembly; //Field offset: 0x8
	private LoadHint loadHint; //Field offset: 0xC

	public DependencyAttribute(string dependentAssemblyArgument, LoadHint loadHintArgument) { }

}

