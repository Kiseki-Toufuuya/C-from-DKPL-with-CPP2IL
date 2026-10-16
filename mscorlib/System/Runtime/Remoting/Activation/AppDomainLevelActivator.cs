namespace System.Runtime.Remoting.Activation;

internal class AppDomainLevelActivator : IActivator
{
	private string _activationUrl; //Field offset: 0x8
	private IActivator _next; //Field offset: 0xC

	public override IActivator NextActivator
	{
		 get { } //Length: 11
	}

	public AppDomainLevelActivator(string activationUrl, IActivator next) { }

	public override IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

	public override IActivator get_NextActivator() { }

}

