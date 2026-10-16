namespace Heqet;

public class RecommendCardModel : EntityBase<RecommendCardModel, Int32>
{
	public int ID; //Field offset: 0xC
	public Int32[] Mission1; //Field offset: 0x10
	public Int32[] Mission2; //Field offset: 0x14
	public Int32[] Gimmick1; //Field offset: 0x18
	public Int32[] Gimmick2; //Field offset: 0x1C
	public Int32[] Gimmick3; //Field offset: 0x20
	public Int32[] StageClear; //Field offset: 0x24

	public RecommendCardModel() { }

}

