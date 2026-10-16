namespace Unity.Services.Core.Configuration;

internal class ConfigurationEntry
{
	[JsonRequired]
	[SerializeField]
	private string m_Value; //Field offset: 0x8
	[JsonRequired]
	[SerializeField]
	private bool m_IsReadOnly; //Field offset: 0xC

	[JsonIgnore]
	public bool IsReadOnly
	{
		 get { } //Length: 11
	}

	[JsonIgnore]
	public string Value
	{
		 get { } //Length: 11
	}

	public ConfigurationEntry() { }

	public ConfigurationEntry(string value, bool isReadOnly = false) { }

	public bool get_IsReadOnly() { }

	public string get_Value() { }

	public static string op_Implicit(ConfigurationEntry entry) { }

	public static ConfigurationEntry op_Implicit(string value) { }

	public bool TrySetValue(string value) { }

}

