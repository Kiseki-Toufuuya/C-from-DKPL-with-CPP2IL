namespace System.Runtime.Serialization;

internal sealed class CreateXmlSerializableDelegate : MulticastDelegate
{

	public CreateXmlSerializableDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public override IXmlSerializable EndInvoke(IAsyncResult result) { }

	public override IXmlSerializable Invoke() { }

}

