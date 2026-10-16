namespace System.Net.Configuration;

[ConfigurationCollection(typeof(WebRequestModuleElement))]
[DefaultMember("Item")]
public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection
{

	public WebRequestModuleElementCollection() { }

	protected virtual ConfigurationElement CreateNewElement() { }

	protected virtual object GetElementKey(ConfigurationElement element) { }

}

