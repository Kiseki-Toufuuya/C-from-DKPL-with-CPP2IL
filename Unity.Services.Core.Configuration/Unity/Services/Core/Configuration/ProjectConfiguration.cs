namespace Unity.Services.Core.Configuration;

internal class ProjectConfiguration : IProjectConfiguration, IServiceComponent
{
	private readonly IReadOnlyDictionary<String, ConfigurationEntry> m_ConfigValues; //Field offset: 0x8
	[CompilerGenerated]
	private readonly IJsonSerializer <Serializer>k__BackingField; //Field offset: 0xC

	public ProjectConfiguration(IReadOnlyDictionary<String, ConfigurationEntry> configValues, IJsonSerializer serializer) { }

	public override string GetString(string key, string defaultValue = null) { }

}

