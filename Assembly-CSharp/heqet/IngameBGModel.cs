namespace Heqet;

public class IngameBGModel : EntityBase<IngameBGModel, Int32>
{
	public int ID; //Field offset: 0xC
	public string AssetName; //Field offset: 0x10
	public Texture2D AssetReference; //Field offset: 0x14

	public IngameBGModel() { }

}

