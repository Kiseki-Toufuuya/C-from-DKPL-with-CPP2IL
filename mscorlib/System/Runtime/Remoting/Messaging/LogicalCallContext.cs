namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
public sealed class LogicalCallContext : ISerializable, ICloneable
{
	public struct Reader
	{
		private LogicalCallContext m_ctx; //Field offset: 0x0

		public bool HasInfo
		{
			 get { } //Length: 29
		}

		public bool IsNull
		{
			 get { } //Length: 14
		}

		public Reader(LogicalCallContext ctx) { }

		public LogicalCallContext Clone() { }

		public bool get_HasInfo() { }

		public bool get_IsNull() { }

		public object GetData(string name) { }

	}

	private static Type s_callContextType; //Field offset: 0x0
	private Hashtable m_Datastore; //Field offset: 0x8
	private CallContextRemotingData m_RemotingData; //Field offset: 0xC
	private CallContextSecurityData m_SecurityData; //Field offset: 0x10
	private object m_HostContext; //Field offset: 0x14
	private bool m_IsCorrelationMgr; //Field offset: 0x18

	private Hashtable Datastore
	{
		private get { } //Length: 87
	}

	public bool HasInfo
	{
		 get { } //Length: 91
	}

	private bool HasUserData
	{
		private get { } //Length: 46
	}

	private static LogicalCallContext() { }

	internal LogicalCallContext() { }

	internal LogicalCallContext(SerializationInfo info, StreamingContext context) { }

	public override object Clone() { }

	private Hashtable get_Datastore() { }

	public bool get_HasInfo() { }

	private bool get_HasUserData() { }

	public object GetData(string name) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal void Merge(LogicalCallContext lc) { }

	public void SetData(string name, object data) { }

}

