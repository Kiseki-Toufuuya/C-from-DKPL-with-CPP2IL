namespace XeApp.Game;

public class GameParamMaster
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LoadContext> <>9__5_1; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <Initialize>b__5_1(LoadContext context) { }

	}

	internal class GameDefineData
	{
		public int addCharaExp; //Field offset: 0x8

		public GameDefineData() { }

	}

	internal class GameMasterData
	{
		public NotesTapValue notes; //Field offset: 0x8
		public NotesScore notesScore; //Field offset: 0xC
		public AdvConstants advConstants; //Field offset: 0x10
		public GameDefineData GameDefine; //Field offset: 0x14

		public GameMasterData() { }

	}

	internal class NotesTapValue
	{
		public Int32[] tap_st; //Field offset: 0x8
		public Int32[] tap_ed; //Field offset: 0xC
		public Int32[] prs_st; //Field offset: 0x10
		public Int32[] prs_ed; //Field offset: 0x14
		public Int32[] rel_st; //Field offset: 0x18
		public Int32[] rel_ed; //Field offset: 0x1C
		public Int32[] slide_st; //Field offset: 0x20
		public Int32[] slide_ed; //Field offset: 0x24
		public Int32[] s_flk_st; //Field offset: 0x28
		public Int32[] s_flk_ed; //Field offset: 0x2C
		public Int32[] l_flk_st; //Field offset: 0x30
		public Int32[] l_flk_ed; //Field offset: 0x34
		public Int32[] sl_rel_st; //Field offset: 0x38
		public Int32[] sl_rel_ed; //Field offset: 0x3C
		public Int32[] sl_flk_st; //Field offset: 0x40
		public Int32[] sl_flk_ed; //Field offset: 0x44
		public Int32[] pas_st; //Field offset: 0x48
		public Int32[] pas_ed; //Field offset: 0x4C

		public NotesTapValue() { }

	}

	public GameMasterData GMasterData; //Field offset: 0x8

	public GameParamMaster() { }

	[CompilerGenerated]
	private void <Initialize>b__5_0(LoadContext context) { }

	public float GetAdvXPosition(int posNo) { }

	public float GetAdvYPosition(int posNo) { }

	public void Initialize() { }

}

