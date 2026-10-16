namespace System.Runtime.Remoting.Proxies;

[ComVisible(True)]
public abstract class RealProxy
{
	private Type class_to_proxy; //Field offset: 0x8
	internal Context _targetContext; //Field offset: 0xC
	internal MarshalByRefObject _server; //Field offset: 0x10
	private int _targetDomainId; //Field offset: 0x14
	internal string _targetUri; //Field offset: 0x18
	internal Identity _objectIdentity; //Field offset: 0x1C
	private object _objTP; //Field offset: 0x20
	private object _stubData; //Field offset: 0x24

	internal Identity ObjectIdentity
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	protected RealProxy() { }

	protected RealProxy(Type classToProxy) { }

	internal RealProxy(Type classToProxy, ClientIdentity identity) { }

	protected RealProxy(Type classToProxy, IntPtr stub, object stubData) { }

	protected void AttachServer(MarshalByRefObject s) { }

	internal Identity get_ObjectIdentity() { }

	internal object GetAppDomainTarget() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public Type GetProxiedType() { }

	public override object GetTransparentProxy() { }

	private static Type InternalGetProxyType(object transparentProxy) { }

	internal override object InternalGetTransparentProxy(string className) { }

	public abstract IMessage Invoke(IMessage msg) { }

	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out Object[] out_args) { }

	private static Object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call) { }

	internal void set_ObjectIdentity(Identity value) { }

	internal void SetTargetDomain(int domainId) { }

}

