namespace System.Net.Configuration;

[ConfigurationCollection(typeof(BypassElement))]
[DefaultMember("Item")]
public sealed class BypassElementCollection : ConfigurationElementCollection
{

	public BypassElementCollection() { }

	protected virtual ConfigurationElement CreateNewElement() { }

	protected virtual object GetElementKey(ConfigurationElement element) { }

}

