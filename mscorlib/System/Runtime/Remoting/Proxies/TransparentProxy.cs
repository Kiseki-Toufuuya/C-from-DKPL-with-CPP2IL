namespace System.Runtime.Remoting.Proxies;

internal class TransparentProxy
{
	public RealProxy _rp; //Field offset: 0x8
	private RuntimeRemoteClassHandle _class; //Field offset: 0xC
	private bool _custom_type_info; //Field offset: 0x10

	private bool IsContextBoundObject
	{
		private get { } //Length: 170
	}

	private Context TargetContext
	{
		private get { } //Length: 23
	}

	public TransparentProxy() { }

	private bool get_IsContextBoundObject() { }

	private Context get_TargetContext() { }

	internal RuntimeType GetProxyType() { }

	private bool InCurrentContext() { }

	internal object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr) { }

	internal void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, object arg) { }

}

