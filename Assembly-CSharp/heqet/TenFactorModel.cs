namespace Heqet;

public class TenFactorModel : EntityBase<TenFactorModel, Int32>
{
	public int ID; //Field offset: 0xC
	public int Min; //Field offset: 0x10
	public int Max; //Field offset: 0x14
	public float TenFactor; //Field offset: 0x18

	public TenFactorModel() { }

}

