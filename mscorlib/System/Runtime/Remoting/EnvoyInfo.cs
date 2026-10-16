namespace System.Runtime.Remoting;

internal class EnvoyInfo : IEnvoyInfo
{
	private IMessageSink envoySinks; //Field offset: 0x8

	public override IMessageSink EnvoySinks
	{
		 get { } //Length: 11
	}

	public EnvoyInfo(IMessageSink sinks) { }

	public override IMessageSink get_EnvoySinks() { }

}

