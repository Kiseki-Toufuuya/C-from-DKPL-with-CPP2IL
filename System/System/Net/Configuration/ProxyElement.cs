namespace System.Net.Configuration;

public sealed class ProxyElement : ConfigurationElement
{

	protected virtual ConfigurationPropertyCollection Properties
	{
		 get { } //Length: 40
	}

	public ProxyElement() { }

	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

