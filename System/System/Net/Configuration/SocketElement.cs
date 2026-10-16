namespace System.Net.Configuration;

public sealed class SocketElement : ConfigurationElement
{

	protected virtual ConfigurationPropertyCollection Properties
	{
		 get { } //Length: 40
	}

	public SocketElement() { }

	protected virtual ConfigurationPropertyCollection get_Properties() { }

	protected virtual void PostDeserialize() { }

}

