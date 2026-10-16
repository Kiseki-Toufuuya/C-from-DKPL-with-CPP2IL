namespace System.Resources;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = False)]
public sealed class SatelliteContractVersionAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <Version>k__BackingField; //Field offset: 0x8

	public string Version
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public SatelliteContractVersionAttribute(string version) { }

	[CompilerGenerated]
	public string get_Version() { }

}

