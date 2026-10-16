namespace Heqet;

public class HeqetMusicTitleJpModel : EntityBase<HeqetMusicTitleJpModel, Int32>
{
	public int ID; //Field offset: 0xC
	public string Title; //Field offset: 0x10
	public string TitleYomi; //Field offset: 0x14
	public string Circle; //Field offset: 0x18
	public string CircleYomi; //Field offset: 0x1C
	public string Vocal; //Field offset: 0x20
	public string VocalYomi; //Field offset: 0x24

	public HeqetMusicTitleJpModel() { }

}

