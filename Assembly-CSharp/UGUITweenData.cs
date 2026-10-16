//Type is in global namespace

public class UGUITweenData : ScriptableObject
{
	[SerializeField]
	private string m_Id; //Field offset: 0xC
	[SerializeField]
	private UGUITweenKeyData m_DefaultData; //Field offset: 0x10
	[SerializeField]
	private List<UGUITweenKeyData> m_KeyList; //Field offset: 0x14
	private Dictionary<String, UGUITweenKeyData> m_KeyDic; //Field offset: 0x18

	public UGUITweenKeyData DefaultData
	{
		 get { } //Length: 11
	}

	public string ID
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public List<UGUITweenKeyData> KeyList
	{
		 get { } //Length: 11
	}

	public UGUITweenData() { }

	public UGUITweenKeyData get_DefaultData() { }

	public string get_ID() { }

	public List<UGUITweenKeyData> get_KeyList() { }

	public UGUITweenKeyData GetKeyData(string label) { }

	public UGUITweenKeyData GetKeyData(int idx) { }

	public void InitKeyDictionary() { }

	public void set_ID(string value) { }

}

