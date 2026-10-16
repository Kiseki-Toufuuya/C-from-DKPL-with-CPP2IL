namespace Heqet;

public class HeqetHelpGroupModel : EntityBase<HeqetHelpGroupModel, Int32>
{
	public int ID; //Field offset: 0xC
	public int SortNo; //Field offset: 0x10
	public string Name; //Field offset: 0x14
	public HeqetHelpPageModel[] Pages; //Field offset: 0x18
	public bool Hidden; //Field offset: 0x1C
	public long FirstMaskFlag; //Field offset: 0x20

	public HeqetHelpGroupModel() { }

}

