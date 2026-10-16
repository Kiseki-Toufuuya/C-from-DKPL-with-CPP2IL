namespace System.Runtime.Remoting;

internal class DisposerReplySink : IMessageSink
{
	private IMessageSink _next; //Field offset: 0x8
	private IDisposable _disposable; //Field offset: 0xC

	public DisposerReplySink(IMessageSink next, IDisposable disposable) { }

	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	public override IMessage SyncProcessMessage(IMessage msg) { }

}

