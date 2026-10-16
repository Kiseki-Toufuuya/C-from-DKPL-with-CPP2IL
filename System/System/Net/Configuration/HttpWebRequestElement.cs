namespace System.Net.Configuration;

public sealed class HttpWebRequestElement : ConfigurationElement
{

	protected virtual ConfigurationPropertyCollection Properties
	{
		 get { } //Length: 40
	}

	public HttpWebRequestElement() { }

	protected virtual ConfigurationPropertyCollection get_Properties() { }

	protected virtual void PostDeserialize() { }

}

