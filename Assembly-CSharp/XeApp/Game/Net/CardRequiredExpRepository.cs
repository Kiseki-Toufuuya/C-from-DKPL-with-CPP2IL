namespace XeApp.Game.Net;

public class CardRequiredExpRepository
{
	private CardRequiredExpScriptableObject m_scriptableObject; //Field offset: 0x8
	private Int32[2] expTable; //Field offset: 0xC

	public int MaxLevel
	{
		 get { } //Length: 60
	}

	public CardRequiredExpRepository(CardRequiredExpScriptableObject scriptableObject) { }

	public int get_MaxLevel() { }

	public int GetExp(int growthType, int nowLevel) { }

}

