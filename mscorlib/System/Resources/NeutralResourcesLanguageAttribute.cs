namespace System.Resources;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = False)]
public sealed class NeutralResourcesLanguageAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <CultureName>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly UltimateResourceFallbackLocation <Location>k__BackingField; //Field offset: 0xC

	public string CultureName
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public UltimateResourceFallbackLocation Location
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public NeutralResourcesLanguageAttribute(string cultureName) { }

	[CompilerGenerated]
	public string get_CultureName() { }

	[CompilerGenerated]
	public UltimateResourceFallbackLocation get_Location() { }

}

