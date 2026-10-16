namespace XeApp.Game;

public class GameEventScriptCommandData
{
	private const int DATA_INT_MAX = 20; //Field offset: 0x0
	private int m_ListId; //Field offset: 0x8
	private eCommand m_Command; //Field offset: 0xC
	private string m_DataString; //Field offset: 0x10
	private string m_DataString2; //Field offset: 0x14
	private string m_DataString3; //Field offset: 0x18
	private string m_MainText; //Field offset: 0x1C
	private string m_EmphasisText; //Field offset: 0x20
	private List<String> m_EmphasisList; //Field offset: 0x24
	private String[] m_ValiableArray; //Field offset: 0x28
	private string m_TalkOption; //Field offset: 0x2C
	private Int32[] m_DataInt; //Field offset: 0x30
	private string m_MesasgeId; //Field offset: 0x34

	public eCommand Command
	{
		 get { } //Length: 11
	}

	public Int32[] DataInt
	{
		 get { } //Length: 11
	}

	public string DataString
	{
		 get { } //Length: 11
	}

	public string DataString2
	{
		 get { } //Length: 11
	}

	public string DataString3
	{
		 get { } //Length: 11
	}

	public List<String> EmphasisList
	{
		 set { } //Length: 27
	}

	public string EmphasisText
	{
		 get { } //Length: 11
	}

	public int ListId
	{
		 get { } //Length: 11
	}

	public string MainText
	{
		 get { } //Length: 11
		 set { } //Length: 495
	}

	public string MesasgeId
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string TalkOption
	{
		 get { } //Length: 11
	}

	public GameEventScriptCommandData(int list_id) { }

	public eCommand get_Command() { }

	public Int32[] get_DataInt() { }

	public string get_DataString() { }

	public string get_DataString2() { }

	public string get_DataString3() { }

	public string get_EmphasisText() { }

	public int get_ListId() { }

	public string get_MainText() { }

	public string get_MesasgeId() { }

	public string get_TalkOption() { }

	private string GetCharaID(string source) { }

	private int GetSystemSeID(string id) { }

	public void set_EmphasisList(List<String> value) { }

	public void set_MainText(string value) { }

	public void set_MesasgeId(string value) { }

	public void SetCommandData(string data) { }

	public string SetValiable(string source) { }

	private static bool TryParseAddMotionIndex(string source, out int ret_index) { }

	private static bool TryParseSDAnimIndex(string source, out int ret_index) { }

	private static bool TryParseSDFaceIndex(string source, out int ret_index) { }

}

