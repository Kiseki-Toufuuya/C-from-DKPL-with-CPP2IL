namespace Heqet;

public class HeqetMusicFolderModel : EntityBase<HeqetMusicFolderModel, Int32>
{
	public int ID; //Field offset: 0xC
	public string Name; //Field offset: 0x10
	public int Filter; //Field offset: 0x14
	public int ImageID; //Field offset: 0x18
	public int Enable; //Field offset: 0x1C
	public int Parent; //Field offset: 0x20

	public HeqetMusicFolderModel() { }

}

