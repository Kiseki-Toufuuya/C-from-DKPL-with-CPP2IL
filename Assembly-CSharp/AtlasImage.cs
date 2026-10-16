//Type is in global namespace

public class AtlasImage : Image
{
	[SerializeField]
	private SpriteAtlas m_Atlas; //Field offset: 0xB4
	[SerializeField]
	private string m_SpriteName; //Field offset: 0xB8
	private Sprite m_NowSprite; //Field offset: 0xBC

	public SpriteAtlas atlas
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public string spriteName
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public AtlasImage() { }

	public SpriteAtlas get_atlas() { }

	public string get_spriteName() { }

	public void set_atlas(SpriteAtlas value) { }

	public void set_spriteName(string value) { }

}

