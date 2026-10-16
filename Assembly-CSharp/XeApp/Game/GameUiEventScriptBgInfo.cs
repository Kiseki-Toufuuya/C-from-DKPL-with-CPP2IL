namespace XeApp.Game;

public class GameUiEventScriptBgInfo
{
	private RectTransform m_AnmTrs; //Field offset: 0x8
	private Vector2 m_Offset; //Field offset: 0xC
	private bool m_Init; //Field offset: 0x14

	public bool IsInit
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Vector2 OffsetPos
	{
		 get { } //Length: 39
		 set { } //Length: 20
	}

	public RectTransform Trs
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public GameUiEventScriptBgInfo() { }

	public bool get_IsInit() { }

	public Vector2 get_OffsetPos() { }

	public RectTransform get_Trs() { }

	public void set_IsInit(bool value) { }

	public void set_OffsetPos(Vector2 value) { }

	public void set_Trs(RectTransform value) { }

}

