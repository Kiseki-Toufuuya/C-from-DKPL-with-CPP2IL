namespace XeSys.Gfx;

public class TextureSliceData
{
	private Dictionary<String, Rect> mDic; //Field offset: 0x8

	public TextureSliceData() { }

	public void Add(string name, Rect rect) { }

	public void Add(string name, float u, float v, float w, float h) { }

	public void Clear() { }

	public Rect GetRect(string name) { }

}

