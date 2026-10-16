namespace System.Runtime.Versioning;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = False, Inherited = False)]
public sealed class TargetFrameworkAttribute : Attribute
{
	private string _frameworkName; //Field offset: 0x8
	private string _frameworkDisplayName; //Field offset: 0xC

	public string FrameworkDisplayName
	{
		 set { } //Length: 27
	}

	public TargetFrameworkAttribute(string frameworkName) { }

	public void set_FrameworkDisplayName(string value) { }

}

