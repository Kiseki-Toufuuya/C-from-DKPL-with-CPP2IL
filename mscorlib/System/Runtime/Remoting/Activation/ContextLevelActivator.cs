namespace System.Runtime.Remoting.Activation;

internal class ContextLevelActivator : IActivator
{
	private IActivator m_NextActivator; //Field offset: 0x8

	public override IActivator NextActivator
	{
		 get { } //Length: 11
	}

	public ContextLevelActivator(IActivator next) { }

	public override IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

	public override IActivator get_NextActivator() { }

}

