namespace System.Runtime.Remoting.Contexts;

internal class DynamicPropertyCollection
{
	private class DynamicPropertyReg
	{
		public IDynamicProperty Property; //Field offset: 0x8
		public IDynamicMessageSink Sink; //Field offset: 0xC

		public DynamicPropertyReg() { }

	}

	private ArrayList _properties; //Field offset: 0x8

	public bool HasProperties
	{
		 get { } //Length: 45
	}

	public DynamicPropertyCollection() { }

	private int FindProperty(string name) { }

	public bool get_HasProperties() { }

	public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async) { }

	public bool RegisterDynamicProperty(IDynamicProperty prop) { }

	public bool UnregisterDynamicProperty(string name) { }

}

