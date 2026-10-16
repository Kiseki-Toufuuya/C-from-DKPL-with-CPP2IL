namespace System.Xml;

public interface IStreamProvider
{

	public Stream GetStream() { }

	public void ReleaseStream(Stream stream) { }

}

