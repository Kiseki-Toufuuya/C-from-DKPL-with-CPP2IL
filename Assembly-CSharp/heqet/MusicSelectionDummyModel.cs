namespace Heqet;

public class MusicSelectionDummyModel : EntityBase<MusicSelectionDummyModel, Int32>
{
	public int ID; //Field offset: 0xC
	public string Title; //Field offset: 0x10
	public string TitleYomi; //Field offset: 0x14
	public Int64[] MusicIds; //Field offset: 0x18
	public int SortNo; //Field offset: 0x1C
	public int CoverId; //Field offset: 0x20
	public int BackGroundId; //Field offset: 0x24
	public int Cost; //Field offset: 0x28

	public MusicSelectionDummyModel() { }

}

