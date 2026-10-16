namespace System.Xml.Serialization;

public class UnreferencedObjectEventArgs : EventArgs
{
	private object o; //Field offset: 0x8
	private string id; //Field offset: 0xC

	public UnreferencedObjectEventArgs(object o, string id) { }

}

