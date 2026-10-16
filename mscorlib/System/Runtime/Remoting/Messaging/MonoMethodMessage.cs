namespace System.Runtime.Remoting.Messaging;

internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage
{
	private RuntimeMethodInfo method; //Field offset: 0x8
	private Object[] args; //Field offset: 0xC
	private String[] names; //Field offset: 0x10
	private Byte[] arg_types; //Field offset: 0x14
	public LogicalCallContext ctx; //Field offset: 0x18
	public object rval; //Field offset: 0x1C
	public Exception exc; //Field offset: 0x20
	private AsyncResult asyncResult; //Field offset: 0x24
	private CallType call_type; //Field offset: 0x28
	private string uri; //Field offset: 0x2C
	private MCMDictionary properties; //Field offset: 0x30
	private Identity identity; //Field offset: 0x34
	private Type[] methodSignature; //Field offset: 0x38

	public override int ArgCount
	{
		 get { } //Length: 49
	}

	public override Object[] Args
	{
		 get { } //Length: 11
	}

	public AsyncResult AsyncResult
	{
		 get { } //Length: 11
	}

	internal CallType CallType
	{
		internal get { } //Length: 95
	}

	public override Exception Exception
	{
		 get { } //Length: 11
	}

	public override LogicalCallContext LogicalCallContext
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override MethodBase MethodBase
	{
		 get { } //Length: 11
	}

	public override string MethodName
	{
		 get { } //Length: 74
	}

	public override object MethodSignature
	{
		 get { } //Length: 276
	}

	public override int OutArgCount
	{
		 get { } //Length: 74
	}

	public override Object[] OutArgs
	{
		 get { } //Length: 278
	}

	public override IDictionary Properties
	{
		 get { } //Length: 88
	}

	public override object ReturnValue
	{
		 get { } //Length: 11
	}

	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
	{
		private get { } //Length: 11
		private set { } //Length: 27
	}

	public override string TypeName
	{
		 get { } //Length: 98
	}

	public override string Uri
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public MonoMethodMessage(MethodBase method, Object[] out_args) { }

	internal MonoMethodMessage(MethodInfo minfo, Object[] in_args, Object[] out_args) { }

	public MonoMethodMessage(Type type, string methodName, Object[] in_args) { }

	public override int get_ArgCount() { }

	public override Object[] get_Args() { }

	public AsyncResult get_AsyncResult() { }

	internal CallType get_CallType() { }

	public override Exception get_Exception() { }

	public override LogicalCallContext get_LogicalCallContext() { }

	public override MethodBase get_MethodBase() { }

	public override string get_MethodName() { }

	public override object get_MethodSignature() { }

	public override int get_OutArgCount() { }

	public override Object[] get_OutArgs() { }

	public override IDictionary get_Properties() { }

	public override object get_ReturnValue() { }

	public override string get_TypeName() { }

	public override string get_Uri() { }

	public override object GetArg(int arg_num) { }

	private static MethodInfo GetMethodInfo(Type type, string methodName) { }

	internal void InitMessage(RuntimeMethodInfo method, Object[] out_args) { }

	public bool NeedsOutProcessing(out int outCount) { }

	public void set_LogicalCallContext(LogicalCallContext value) { }

	public override void set_Uri(string value) { }

	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

}

