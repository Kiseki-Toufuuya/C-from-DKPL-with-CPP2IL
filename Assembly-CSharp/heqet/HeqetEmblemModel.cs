namespace Heqet;

public class HeqetEmblemModel : EntityBase<HeqetEmblemModel, Int32>
{
	public int ID; //Field offset: 0xC
	public int HeroineID; //Field offset: 0x10
	public HeqetHeroineModel heqetHeroineModel; //Field offset: 0x14

	public HeqetEmblemModel() { }

}

