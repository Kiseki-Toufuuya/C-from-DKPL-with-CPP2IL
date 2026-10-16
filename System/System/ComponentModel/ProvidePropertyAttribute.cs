namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = True)]
public sealed class ProvidePropertyAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <PropertyName>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly string <ReceiverTypeName>k__BackingField; //Field offset: 0xC

	public string PropertyName
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public string ReceiverTypeName
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	[CompilerGenerated]
	public string get_PropertyName() { }

	[CompilerGenerated]
	public string get_ReceiverTypeName() { }

}

