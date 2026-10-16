namespace Heqet;

public class AchievementModel : EntityBase<AchievementModel, Int32>
{
	internal enum ItemType
	{
		Card = 0,
		Emblem = 1,
		Heroine = 2,
	}

	public int ID; //Field offset: 0xC
	public string Name; //Field offset: 0x10
	public string Description; //Field offset: 0x14
	public string Reward; //Field offset: 0x18
	public int ImageID; //Field offset: 0x1C
	public int HiddenElement; //Field offset: 0x20
	public int SkillType; //Field offset: 0x24
	public int BuffID; //Field offset: 0x28
	public ItemType ItemTypeID; //Field offset: 0x2C
	public int ItemID; //Field offset: 0x30
	public string SteamApiName; //Field offset: 0x34
	public int PS4trophyId; //Field offset: 0x38

	public AchievementModel() { }

}

