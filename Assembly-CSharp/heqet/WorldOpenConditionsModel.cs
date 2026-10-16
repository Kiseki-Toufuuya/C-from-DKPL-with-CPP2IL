namespace Heqet;

public class WorldOpenConditionsModel : EntityBase<WorldOpenConditionsModel, Int32>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public int areaId; //Field offset: 0x8

		public <>c__DisplayClass6_0() { }

		internal bool <IsAreaOpen>b__0(int aId) { }

	}

	internal enum OpenConditionType
	{
		StageClear = 0,
		AreaOpen = 1,
		RenaissanceExceeded = 2,
		AcquiredHeroine = 3,
		AcquiredMitamaCard = 4,
		AcquiredEmblem = 5,
	}

	public int ID; //Field offset: 0xC
	public OpenConditionType OpenConditionTypeID; //Field offset: 0x10
	public Int32[] Params; //Field offset: 0x14

	public WorldOpenConditionsModel() { }

	public bool CheckConditions() { }

	private bool IsAreaOpen() { }

	private bool IsRenaissanceExceeded() { }

	private bool isStageClear() { }

}

