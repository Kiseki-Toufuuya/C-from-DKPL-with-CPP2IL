namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Assembly (1))]
public sealed class DefaultDependencyAttribute : Attribute
{
	private LoadHint loadHint; //Field offset: 0x8

	public DefaultDependencyAttribute(LoadHint loadHintArgument) { }

}

