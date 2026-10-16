namespace XeSys.Gfx;

[DefaultMember("Item")]
public class TexUVListManager
{
	private List<TexUVList> m_ListList; //Field offset: 0x8

	public int Count
	{
		 get { } //Length: 52
	}

	public bool IsClear
	{
		 get { } //Length: 181
	}

	public TexUVList Item
	{
		 get { } //Length: 67
	}

	public TexUVListManager() { }

	public TexUVListManager(int count) { }

	public TexUVListManager(TexUVList[] list) { }

	public void Add(TexUVList uvList) { }

	public void Add(TexUVListManager uvMan) { }

	public void Add(TexUVList uvList, Texture2D texture) { }

	public void Add(Byte[] uvList, Texture2D texture) { }

	public bool CheckRegistration(int count) { }

	public void Clear() { }

	public int get_Count() { }

	public bool get_IsClear() { }

	public TexUVList get_Item(int index) { }

	public TexUVData GetTextureData(string key, out TexUVList texUVList) { }

	public TexUVList GetTexUVList(string texName) { }

	public TexUVData GetUVData(string key) { }

	public void Register(int index, TexUVList uvList) { }

	private void Reserve(int count) { }

}

