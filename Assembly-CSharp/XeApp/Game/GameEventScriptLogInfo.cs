namespace XeApp.Game;

public class GameEventScriptLogInfo
{
	internal enum eCharaIconType
	{
		None = 0,
		Normal = 1,
		Sd = 2,
	}

	internal enum eTextType
	{
		TEXT = 0,
		INFO = 1,
	}

	private string m_Name; //Field offset: 0x8
	private string m_Text; //Field offset: 0xC
	private string m_MessageId; //Field offset: 0x10
	private int m_CharaId; //Field offset: 0x14
	private int m_SkinId; //Field offset: 0x18
	private eCharaIconType m_CharaIconType; //Field offset: 0x1C
	private Sprite m_CharaIcon; //Field offset: 0x20
	private eTextType m_type; //Field offset: 0x24

	public Sprite CharaIcon
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public eCharaIconType CharaIconType
	{
		 get { } //Length: 11
	}

	public int CharaId
	{
		 get { } //Length: 11
	}

	public string MessageId
	{
		 get { } //Length: 11
	}

	public string Name
	{
		 get { } //Length: 11
	}

	public int SkinId
	{
		 get { } //Length: 11
	}

	public string Text
	{
		 get { } //Length: 11
	}

	public eTextType TextType
	{
		 get { } //Length: 11
	}

	public GameEventScriptLogInfo(string name, string text, string messageId, int charaId, int skin, eCharaIconType charaicontype, eTextType type = 0) { }

	public Sprite get_CharaIcon() { }

	public eCharaIconType get_CharaIconType() { }

	public int get_CharaId() { }

	public string get_MessageId() { }

	public string get_Name() { }

	public int get_SkinId() { }

	public string get_Text() { }

	public eTextType get_TextType() { }

	public void set_CharaIcon(Sprite value) { }

}

