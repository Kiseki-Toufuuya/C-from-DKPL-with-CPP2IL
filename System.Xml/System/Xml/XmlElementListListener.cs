namespace System.Xml;

internal class XmlElementListListener
{
	private WeakReference elemList; //Field offset: 0x8
	private XmlDocument doc; //Field offset: 0xC
	private XmlNodeChangedEventHandler nodeChangeHandler; //Field offset: 0x10

	internal XmlElementListListener(XmlDocument doc, XmlElementList elemList) { }

	private void OnListChanged(object sender, XmlNodeChangedEventArgs args) { }

	internal void Unregister() { }

}

