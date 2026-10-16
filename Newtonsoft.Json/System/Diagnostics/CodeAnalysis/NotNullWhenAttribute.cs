namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets::Parameter (2048), AllowMultiple = False)]
internal sealed class NotNullWhenAttribute : Attribute
{
	[CompilerGenerated]
	private readonly bool <ReturnValue>k__BackingField; //Field offset: 0x8

	public NotNullWhenAttribute(bool returnValue) { }

}

