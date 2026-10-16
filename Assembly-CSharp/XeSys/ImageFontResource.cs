namespace XeSys;

public abstract class ImageFontResource : IDisposable
{
	protected Dictionary<Char, ImageFontCharacter> mCharaList; //Field offset: 0x8
	protected List<ImageFontTexture> mTextureList; //Field offset: 0xC

	public abstract bool isReady
	{
		 get { } //Length: 0
	}

	public ImageFontResource() { }

	public void AddTexture(Texture2D tex) { }

	public void AddTexture(Texture2D tex, string shaderName) { }

	public override void Dispose() { }

	protected abstract void DoDispose() { }

	public ImageFontCharacter Get(char chr) { }

	public abstract bool get_isReady() { }

	public ImageFontTexture GetTexture(int page) { }

	public abstract void ReadSliceData(string sliceData) { }

}

