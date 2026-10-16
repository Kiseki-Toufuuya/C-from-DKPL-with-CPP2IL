namespace XeApp.Game;

public class DialogItemDetailData
{
	private int m_ItemPrefix; //Field offset: 0x8
	private int m_ItemValue; //Field offset: 0xC
	private int m_ImageId; //Field offset: 0x10
	private string m_ClubId; //Field offset: 0x14
	private bool m_IsForceHaveCount; //Field offset: 0x18
	private long m_EventRanking; //Field offset: 0x20
	private bool m_IsForceRewardEmblem; //Field offset: 0x28

	public DialogItemDetailData(int itemPrefix, int itemValue, bool isFoceHaveCount = false) { }

	public DialogItemDetailData(int itemPrefix, int itemValue, int imageId, bool isFoceHaveCount = false) { }

	public DialogItemDetailData(int itemPrefix, int itemValue, int imageId, string clubID, bool isFoceHaveCount = false, bool isForceRewardEmblem = false) { }

	public DialogItemDetailData(int itemPrefix, int itemValue, long EventRanking, bool isForceRewardEmblem = false, bool isForceHaveCount = false) { }

	public long EventRanking() { }

	public string HaveCount() { }

	public bool IsForceHaveCount() { }

	public bool IsForceRewardEmblem() { }

	public string ItemDetail() { }

	public int ItemIconId() { }

	public string ItemName() { }

	public int ItemPrefix() { }

	public int ItemValue() { }

}

