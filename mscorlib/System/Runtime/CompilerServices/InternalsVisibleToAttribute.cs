namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True, Inherited = False)]
public sealed class InternalsVisibleToAttribute : Attribute
{
	private string _assemblyName; //Field offset: 0x8
	private bool _allInternalsVisible; //Field offset: 0xC

	public bool AllInternalsVisible
	{
		 set { } //Length: 14
	}

	public InternalsVisibleToAttribute(string assemblyName) { }

	public void set_AllInternalsVisible(bool value) { }

}

