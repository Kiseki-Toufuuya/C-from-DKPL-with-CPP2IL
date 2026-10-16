namespace System.Runtime.Remoting.Messaging;

[CLSCompliant(False)]
[ComVisible(True)]
public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage
{
	private string _uri; //Field offset: 0x8
	private string _typeName; //Field offset: 0xC
	private string _methodName; //Field offset: 0x10
	private Object[] _args; //Field offset: 0x14
	private Type[] _methodSignature; //Field offset: 0x18
	private MethodBase _methodBase; //Field offset: 0x1C
	private LogicalCallContext _callContext; //Field offset: 0x20
	private Identity _targetIdentity; //Field offset: 0x24
	private Type[] _genericArguments; //Field offset: 0x28
	protected IDictionary ExternalProperties; //Field offset: 0x2C
	protected IDictionary InternalProperties; //Field offset: 0x30

	public override int ArgCount
	{
		 get { } //Length: 23
	}

	public override Object[] Args
	{
		 get { } //Length: 11
	}

	private Type[] GenericArguments
	{
		private get { } //Length: 83
	}

	public override LogicalCallContext LogicalCallContext
	{
		 get { } //Length: 87
	}

	public override MethodBase MethodBase
	{
		 get { } //Length: 43
	}

	public override string MethodName
	{
		 get { } //Length: 64
	}

	public override object MethodSignature
	{
		 get { } //Length: 301
	}

	public override IDictionary Properties
	{
		 get { } //Length: 39
	}

	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
	{
		private get { } //Length: 11
		private set { } //Length: 27
	}

	private override string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
	{
		private get { } //Length: 11
		private set { } //Length: 27
	}

	public override string TypeName
	{
		 get { } //Length: 90
	}

	public override string Uri
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	internal MethodCall(SerializationInfo info, StreamingContext context) { }

	internal MethodCall(CADMethodCallMessage msg) { }

	internal MethodCall() { }

	private Type CastTo(string clientType, Type serverType) { }

	internal void CopyFrom(IMethodMessage call) { }

	public override int get_ArgCount() { }

	public override Object[] get_Args() { }

	private Type[] get_GenericArguments() { }

	public override LogicalCallContext get_LogicalCallContext() { }

	public override MethodBase get_MethodBase() { }

	public override string get_MethodName() { }

	public override object get_MethodSignature() { }

	public override IDictionary get_Properties() { }

	public override string get_TypeName() { }

	public override string get_Uri() { }

	public override object GetArg(int argNum) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private static string GetTypeNameFromAssemblyQualifiedName(string aqname) { }

	public override void Init() { }

	internal override void InitDictionary() { }

	internal override void InitMethodProperty(string key, object value) { }

	public void ResolveMethod() { }

	public void set_Uri(string value) { }

	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	private override string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

}

