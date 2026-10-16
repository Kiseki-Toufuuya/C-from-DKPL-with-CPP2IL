namespace System.Net.Configuration;

public sealed class WebProxyScriptElement : ConfigurationElement
{

	protected virtual ConfigurationPropertyCollection Properties
	{
		 get { } //Length: 40
	}

	public WebProxyScriptElement() { }

	protected virtual ConfigurationPropertyCollection get_Properties() { }

	protected virtual void PostDeserialize() { }

}

