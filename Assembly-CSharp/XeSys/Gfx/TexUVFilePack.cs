namespace XeSys.Gfx;

public class TexUVFilePack : ScriptableObject
{
	[HideInInspector]
	[SerializeField]
	private TextureSet[] m_textureSetList; //Field offset: 0xC
	[SerializeField]
	private TexUVList[] m_uvList; //Field offset: 0x10
	private TexUVListManager m_uvManager; //Field offset: 0x14

	public TextureSet[] TextureSetList
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public TexUVListManager UvManager
	{
		 get { } //Length: 11
	}

	public TexUVFilePack() { }

	public TexUVListManager CreateUvManager() { }

	public TextureSet[] get_TextureSetList() { }

	public TexUVListManager get_UvManager() { }

	public TextureSet GetTextureSet(string texName) { }

	public void Init() { }

	private void InitSpriteDictionary() { }

	private void InitUvManagerSprite() { }

	private void OnEnable() { }

	public void set_TextureSetList(TextureSet[] value) { }

}

