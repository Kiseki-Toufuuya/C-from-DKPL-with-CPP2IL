namespace XeApp.Game;

public class GameEventScriptCommandList
{
	private GameEventScriptCommandData[] m_DataList; //Field offset: 0x8
	private string m_DataName; //Field offset: 0xC
	private List<Int32> m_TexBgList; //Field offset: 0x10
	private List<Int32> m_TexBgStillList; //Field offset: 0x14
	private Int32[] m_TexCodeList; //Field offset: 0x18
	private Int32[] m_TexCharaList; //Field offset: 0x1C
	private Int32[] m_TexFullList; //Field offset: 0x20
	private Int32[] m_InitMotionList; //Field offset: 0x24
	private Int32[] m_InitFaceList; //Field offset: 0x28
	private Int32[] m_InitOptionList; //Field offset: 0x2C
	private Int32[] m_InitEarList; //Field offset: 0x30
	private Int32[] m_InitTailList; //Field offset: 0x34
	private Int32[] m_InitDirectionList; //Field offset: 0x38
	private Int32[] m_InitEmotionList; //Field offset: 0x3C
	private List<Int32> m_TexCardList; //Field offset: 0x40
	private Int32[] m_ModelTypeList; //Field offset: 0x44
	private List<Int32> m_TexItemList; //Field offset: 0x48
	private List<String> m_VoiceCharaList; //Field offset: 0x4C
	private List<Int32> m_EffNoList; //Field offset: 0x50
	private int m_VersionNo; //Field offset: 0x54
	private int m_CommandMax; //Field offset: 0x58
	private int m_TexCharaNum; //Field offset: 0x5C
	private Dictionary<Int32, GameEventScriptSelectInfo> m_SelectInfo; //Field offset: 0x60
	private int m_CardEpisodePageNum; //Field offset: 0x64
	private int m_RythmGamePresetNo; //Field offset: 0x68
	private bool m_IsOverflowWrap; //Field offset: 0x6C

	public int CardEpPageNum
	{
		 get { } //Length: 11
	}

	public int CommandMax
	{
		 get { } //Length: 11
	}

	public GameEventScriptCommandData[] DataList
	{
		 get { } //Length: 11
	}

	public string DataName
	{
		 get { } //Length: 11
	}

	public List<Int32> EffNoList
	{
		 get { } //Length: 11
	}

	public Int32[] InitDirectionList
	{
		 get { } //Length: 11
	}

	public Int32[] InitEarList
	{
		 get { } //Length: 11
	}

	public Int32[] InitEmotionList
	{
		 get { } //Length: 11
	}

	public Int32[] InitFaceList
	{
		 get { } //Length: 11
	}

	public Int32[] InitMotionList
	{
		 get { } //Length: 11
	}

	public Int32[] InitOptionList
	{
		 get { } //Length: 11
	}

	public Int32[] InitTailList
	{
		 get { } //Length: 11
	}

	public Int32[] ModelTypeList
	{
		 get { } //Length: 11
	}

	public int RythmGamePresetNo
	{
		 get { } //Length: 11
	}

	public Dictionary<Int32, GameEventScriptSelectInfo> SelectInfo
	{
		 get { } //Length: 11
	}

	public List<Int32> TexBgList
	{
		 get { } //Length: 11
	}

	public List<Int32> TexBgStillList
	{
		 get { } //Length: 11
	}

	public List<Int32> TexCardList
	{
		 get { } //Length: 11
	}

	public Int32[] TexCharaList
	{
		 get { } //Length: 11
	}

	public int TexCharaNum
	{
		 get { } //Length: 11
	}

	public Int32[] TexCodeList
	{
		 get { } //Length: 11
	}

	public Int32[] TexFullList
	{
		 get { } //Length: 11
	}

	public List<Int32> TexItemList
	{
		 get { } //Length: 11
	}

	public int VersionNo
	{
		 get { } //Length: 11
	}

	public List<String> VoiceCharaList
	{
		 get { } //Length: 11
	}

	public GameEventScriptCommandList() { }

	public int get_CardEpPageNum() { }

	public int get_CommandMax() { }

	public GameEventScriptCommandData[] get_DataList() { }

	public string get_DataName() { }

	public List<Int32> get_EffNoList() { }

	public Int32[] get_InitDirectionList() { }

	public Int32[] get_InitEarList() { }

	public Int32[] get_InitEmotionList() { }

	public Int32[] get_InitFaceList() { }

	public Int32[] get_InitMotionList() { }

	public Int32[] get_InitOptionList() { }

	public Int32[] get_InitTailList() { }

	public Int32[] get_ModelTypeList() { }

	public int get_RythmGamePresetNo() { }

	public Dictionary<Int32, GameEventScriptSelectInfo> get_SelectInfo() { }

	public List<Int32> get_TexBgList() { }

	public List<Int32> get_TexBgStillList() { }

	public List<Int32> get_TexCardList() { }

	public Int32[] get_TexCharaList() { }

	public int get_TexCharaNum() { }

	public Int32[] get_TexCodeList() { }

	public Int32[] get_TexFullList() { }

	public List<Int32> get_TexItemList() { }

	public int get_VersionNo() { }

	public List<String> get_VoiceCharaList() { }

	private string GetEmphasis(string source, ref List<String>& emphasis) { }

	public bool SetCommandList(StringDownloadFile file) { }

}

