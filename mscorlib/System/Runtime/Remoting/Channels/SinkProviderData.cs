namespace System.Runtime.Remoting.Channels;

[ComVisible(True)]
public class SinkProviderData
{
	private string sinkName; //Field offset: 0x8
	private ArrayList children; //Field offset: 0xC
	private Hashtable properties; //Field offset: 0x10

	public IList Children
	{
		 get { } //Length: 11
	}

	public IDictionary Properties
	{
		 get { } //Length: 11
	}

	public SinkProviderData(string name) { }

	public IList get_Children() { }

	public IDictionary get_Properties() { }

}

