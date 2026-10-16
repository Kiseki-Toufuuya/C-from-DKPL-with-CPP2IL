namespace System.Net.Configuration;

[ConfigurationCollection(typeof(ConnectionManagementElement))]
[DefaultMember("Item")]
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection
{

	public ConnectionManagementElementCollection() { }

	protected virtual ConfigurationElement CreateNewElement() { }

	protected virtual object GetElementKey(ConfigurationElement element) { }

}

