namespace XeApp.Game;

public class ComMesDisp
{
	private const int TEXT_SPEED_DEF = 3; //Field offset: 0x0
	private string m_TextMessage; //Field offset: 0x8
	private int m_TextLengthMax; //Field offset: 0xC
	private int m_TextLengthNow; //Field offset: 0x10
	private float m_fCntDisp; //Field offset: 0x14
	private float m_fDispSpeedFrm; //Field offset: 0x18
	private bool m_TextDispAllFg; //Field offset: 0x1C
	private int m_TextObjNo; //Field offset: 0x20
	private String[] m_MessageList; //Field offset: 0x24
	private List<String> m_RubyTagList; //Field offset: 0x28
	private string m_Format; //Field offset: 0x2C
	private bool m_isRuby; //Field offset: 0x30

	public int TextLengthNow
	{
		 get { } //Length: 11
	}

	public int TextObjNo
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public ComMesDisp() { }

	public float ChangeDispSpeedFrm(float speed) { }

	public bool ChkTextFinish() { }

	public int get_TextLengthNow() { }

	public int get_TextObjNo() { }

	public string GetTextMessage(bool space = false) { }

	public void InitDispStart(string text, float speed = 3, bool iRuby = true) { }

	public void SearchRubyTag(ref string text) { }

	public void set_TextObjNo(int value) { }

	public void SetDispAll() { }

	public void SetDispReset() { }

}

