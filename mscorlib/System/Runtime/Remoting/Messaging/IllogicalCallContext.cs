namespace System.Runtime.Remoting.Messaging;

internal class IllogicalCallContext
{
	private Hashtable m_Datastore; //Field offset: 0x8
	private object m_HostContext; //Field offset: 0xC

	private Hashtable Datastore
	{
		private get { } //Length: 87
	}

	internal bool HasUserData
	{
		internal get { } //Length: 46
	}

	internal object HostContext
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	public IllogicalCallContext() { }

	public IllogicalCallContext CreateCopy() { }

	public void FreeNamedDataSlot(string name) { }

	private Hashtable get_Datastore() { }

	internal bool get_HasUserData() { }

	internal object get_HostContext() { }

	internal void set_HostContext(object value) { }

}

