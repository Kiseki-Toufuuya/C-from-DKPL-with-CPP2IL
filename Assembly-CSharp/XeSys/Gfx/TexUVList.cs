namespace XeSys.Gfx;

public class TexUVList : ScriptableObject, ISerializationCallbackReceiver
{
	private enum UVDataTextElm
	{
		id = 0,
		x = 1,
		y = 2,
		w = 3,
		h = 4,
		l = 5,
		t = 6,
		r = 7,
		b = 8,
	}

	private Texture2D m_Texture; //Field offset: 0xC
	[SerializeField]
	private string m_name; //Field offset: 0x10
	[SerializeField]
	private int m_width; //Field offset: 0x14
	[SerializeField]
	private int m_height; //Field offset: 0x18
	[SerializeField]
	private List<TexUVData> m_serializeDatas; //Field offset: 0x1C
	private Dictionary<String, TexUVData> m_UVDataDictionary; //Field offset: 0x20

	public int height
	{
		 get { } //Length: 11
	}

	public string name
	{
		 get { } //Length: 11
	}

	public Texture2D Tex
	{
		 get { } //Length: 11
	}

	public Dictionary<String, TexUVData> UvDataDictionary
	{
		 get { } //Length: 11
	}

	public int width
	{
		 get { } //Length: 11
	}

	public TexUVList() { }

	private void AttachFilterMode(Texture2D texture, string path) { }

	public void Clear() { }

	public int get_height() { }

	public string get_name() { }

	public Texture2D get_Tex() { }

	public Dictionary<String, TexUVData> get_UvDataDictionary() { }

	public int get_width() { }

	public TexUVData GetUVData(string key) { }

	public void Initialize(Byte[] bytes, Texture2D texture) { }

	public void Initialize(Texture2D texture) { }

	public void InitOneTexture(Texture2D tex, string name) { }

	public static TexUVList NewInstance() { }

	private void ReadUVList(string uvListText) { }

	private void ReadUVList(Byte[] uvListBytes) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

