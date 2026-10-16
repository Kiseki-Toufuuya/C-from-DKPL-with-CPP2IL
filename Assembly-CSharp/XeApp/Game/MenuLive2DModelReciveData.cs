namespace XeApp.Game;

public class MenuLive2DModelReciveData
{
	public int CharaId; //Field offset: 0x8
	public string CharaName; //Field offset: 0xC
	public String[] CharaMessage; //Field offset: 0x10
	public String[2] CharaPose; //Field offset: 0x14
	private int PreviousVoiceTextID; //Field offset: 0x18
	private bool isSdChara; //Field offset: 0x1C
	public Direction SdCharaDir; //Field offset: 0x20

	public bool IsSdCharaData
	{
		 get { } //Length: 11
	}

	public MenuLive2DModelReciveData() { }

	public bool get_IsSdCharaData() { }

	public string GetName() { }

}

