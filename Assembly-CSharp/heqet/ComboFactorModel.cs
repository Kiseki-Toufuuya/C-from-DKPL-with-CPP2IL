namespace Heqet;

public class ComboFactorModel : EntityBase<ComboFactorModel, Int32>
{
	public int ID; //Field offset: 0xC
	public int Min; //Field offset: 0x10
	public int Max; //Field offset: 0x14
	public float ComboFactor; //Field offset: 0x18

	public ComboFactorModel() { }

}

