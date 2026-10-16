namespace XeSys;

public class MessageBank : IDisposable
{
	public static string NotExistText; //Field offset: 0x0
	[CompilerGenerated]
	private Dictionary<String, String> <msgDic>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private List<String> <labelList>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private int <columnCount>k__BackingField; //Field offset: 0x10

	public private int columnCount
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public int count
	{
		 get { } //Length: 52
	}

	private List<String> labelList
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private Dictionary<String, String> msgDic
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private static MessageBank() { }

	public MessageBank() { }

	public override void Dispose() { }

	[CompilerGenerated]
	public int get_columnCount() { }

	public int get_count() { }

	[CompilerGenerated]
	private List<String> get_labelList() { }

	[CompilerGenerated]
	private Dictionary<String, String> get_msgDic() { }

	public string GetLabel(int index) { }

	public string GetMessageByIndex(int index, int column = 0) { }

	public string GetMessageByLabel(string label, int column = 0) { }

	public bool IsExist(string label, int column = 0) { }

	private string MakeColumnLabel(string baseLabel, int column) { }

	[CompilerGenerated]
	private void set_columnCount(int value) { }

	[CompilerGenerated]
	private void set_labelList(List<String> value) { }

	[CompilerGenerated]
	private void set_msgDic(Dictionary<String, String> value) { }

	public void Setup(Byte[] bytes) { }

}

