namespace System.Runtime.CompilerServices;

[AttributeUsage(1036, AllowMultiple = True, Inherited = False)]
internal sealed class TypeDependencyAttribute : Attribute
{
	private string typeName; //Field offset: 0x8

	public TypeDependencyAttribute(string typeName) { }

}

