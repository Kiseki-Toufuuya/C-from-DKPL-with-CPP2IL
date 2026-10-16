namespace System;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True)]
internal class MonoTODOAttribute : Attribute
{
	private string comment; //Field offset: 0x8

	public MonoTODOAttribute() { }

	public MonoTODOAttribute(string comment) { }

}

