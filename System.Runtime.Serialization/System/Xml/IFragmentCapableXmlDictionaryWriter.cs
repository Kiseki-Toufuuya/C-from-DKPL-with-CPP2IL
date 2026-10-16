namespace System.Xml;

public interface IFragmentCapableXmlDictionaryWriter
{

	public bool CanFragment
	{
		 get { } //Length: 0
	}

	public void EndFragment() { }

	public bool get_CanFragment() { }

	public void StartFragment(Stream stream, bool generateSelfContainedTextFragment) { }

	public void WriteFragment(Byte[] buffer, int offset, int count) { }

}

