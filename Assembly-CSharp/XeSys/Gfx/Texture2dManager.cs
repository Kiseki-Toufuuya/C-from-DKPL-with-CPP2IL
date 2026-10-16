namespace XeSys.Gfx;

public class Texture2dManager : Singleton<Texture2dManager>, IDisposable
{
	private Dictionary<String, Texture2D> mDic; //Field offset: 0x8

	public Texture2dManager() { }

	public void Add(string name, Texture2D texture) { }

	public void Debug() { }

	public override void Dispose() { }

	public Texture2D Get(string name) { }

	private string MakeDebugLog() { }

	public bool Release(string name) { }

	public void ReleaseAllTexture() { }

}

