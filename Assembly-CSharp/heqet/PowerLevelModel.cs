namespace Heqet;

public class PowerLevelModel : EntityBase<PowerLevelModel, Int32>
{
	public int ID; //Field offset: 0xC
	public float MainShot; //Field offset: 0x10
	public float ExtraShot; //Field offset: 0x14
	public float OptionShot; //Field offset: 0x18

	public PowerLevelModel() { }

}

