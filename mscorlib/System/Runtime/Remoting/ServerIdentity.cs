namespace System.Runtime.Remoting;

internal abstract class ServerIdentity : Identity
{
	protected Type _objectType; //Field offset: 0x24
	protected MarshalByRefObject _serverObject; //Field offset: 0x28
	protected IMessageSink _serverSink; //Field offset: 0x2C
	protected Context _context; //Field offset: 0x30
	protected Lease _lease; //Field offset: 0x34

	public Context Context
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Lease Lease
	{
		 get { } //Length: 11
	}

	public Type ObjectType
	{
		 get { } //Length: 11
	}

	public ServerIdentity(string objectUri, Context context, Type objectType) { }

	public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	public void AttachServerObject(MarshalByRefObject serverObject, Context context) { }

	public virtual ObjRef CreateObjRef(Type requestedType) { }

	protected void DisposeServerObject() { }

	public Context get_Context() { }

	public Lease get_Lease() { }

	public Type get_ObjectType() { }

	public override void OnLifetimeExpired() { }

	public void set_Context(Context value) { }

	public void StartTrackingLifetime(ILease lease) { }

	public abstract IMessage SyncObjectProcessMessage(IMessage msg) { }

}

