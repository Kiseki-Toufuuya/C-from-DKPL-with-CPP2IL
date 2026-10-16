namespace XeSys;

public class ImageFontManager : Singleton<ImageFontManager>, IDisposable
{
	private Dictionary<String, ImageFontWriter> mWriterList; //Field offset: 0x8

	public ImageFontManager() { }

	public void AddWriter(ImageFontWriter writer) { }

	public void Clear() { }

	public override void Dispose() { }

	public bool Remove(string name) { }

}

