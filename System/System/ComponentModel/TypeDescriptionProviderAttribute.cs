namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Class (4), Inherited = True)]
public sealed class TypeDescriptionProviderAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <TypeName>k__BackingField; //Field offset: 0x8

	public string TypeName
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public TypeDescriptionProviderAttribute(string typeName) { }

	[CompilerGenerated]
	public string get_TypeName() { }

}

