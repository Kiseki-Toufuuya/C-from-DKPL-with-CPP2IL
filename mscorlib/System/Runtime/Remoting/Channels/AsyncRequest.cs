namespace System.Runtime.Remoting.Channels;

internal class AsyncRequest
{
	internal IMessageSink ReplySink; //Field offset: 0x8
	internal IMessage MsgRequest; //Field offset: 0xC

	public AsyncRequest(IMessage msgRequest, IMessageSink replySink) { }

}

