namespace System.Net.Configuration;

public sealed class ServicePointManagerElement : ConfigurationElement
{

	protected virtual ConfigurationPropertyCollection Properties
	{
		 get { } //Length: 40
	}

	public ServicePointManagerElement() { }

	protected virtual ConfigurationPropertyCollection get_Properties() { }

	protected virtual void PostDeserialize() { }

}

