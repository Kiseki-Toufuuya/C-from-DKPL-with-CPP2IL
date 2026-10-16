namespace XeSys;

public class MessageManager : Singleton<MessageManager>, IDisposable
{
	[CompilerGenerated]
	private Dictionary<String, MessageBank> <msgBankDic>k__BackingField; //Field offset: 0x8

	private Dictionary<String, MessageBank> msgBankDic
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public MessageManager() { }

	public override void Dispose() { }

	[CompilerGenerated]
	private Dictionary<String, MessageBank> get_msgBankDic() { }

	public MessageBank GetBank(string bankName) { }

	public string GetMessage(string bankName, string labelName) { }

	public bool IsExistBank(string bankName) { }

	public bool IsExistMessage(string bankName, string labelName, int column = 0) { }

	public MessageBank RegisterBank(string bankName, Byte[] bytes) { }

	public void ReleaseBank(string bankName) { }

	[CompilerGenerated]
	private void set_msgBankDic(Dictionary<String, MessageBank> value) { }

}

