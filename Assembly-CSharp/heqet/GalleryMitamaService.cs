namespace Heqet;

public class GalleryMitamaService
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MitamaSortParams, Int32> <>9__4_1; //Field offset: 0x4
		public static Func<MitamaSortParams, Int32> <>9__4_2; //Field offset: 0x8
		public static Func<MitamaSortParams, Int32> <>9__4_3; //Field offset: 0xC
		public static Func<MitamaSortParams, Int32> <>9__4_4; //Field offset: 0x10
		public static Func<MitamaSortParams, Int32> <>9__4_5; //Field offset: 0x14
		public static Func<MitamaSortParams, Int32> <>9__4_6; //Field offset: 0x18
		public static Func<MitamaSortParams, Int32> <>9__4_7; //Field offset: 0x1C
		public static Func<MitamaSortParams, Int32> <>9__4_8; //Field offset: 0x20
		public static Func<MitamaSortParams, Int32> <>9__4_9; //Field offset: 0x24
		public static Func<MitamaSortParams, Int32> <>9__4_10; //Field offset: 0x28
		public static Func<MitamaSortParams, Int32> <>9__4_11; //Field offset: 0x2C
		public static Func<MitamaSortParams, Int32> <>9__4_12; //Field offset: 0x30
		public static Func<MitamaSortParams, Int32> <>9__4_13; //Field offset: 0x34
		public static Func<MitamaSortParams, Int32> <>9__4_14; //Field offset: 0x38
		public static Func<MitamaSortParams, Int32> <>9__4_15; //Field offset: 0x3C
		public static Func<MitamaSortParams, Int32> <>9__4_16; //Field offset: 0x40
		public static Func<MitamaSortParams, Int32> <>9__4_17; //Field offset: 0x44
		public static Func<MitamaSortParams, Int32> <>9__4_18; //Field offset: 0x48
		public static Func<MitamaSortParams, Int32> <>9__4_19; //Field offset: 0x4C
		public static Func<MitamaSortParams, Int32> <>9__4_20; //Field offset: 0x50
		public static Func<MitamaSortParams, Int32> <>9__4_21; //Field offset: 0x54
		public static Func<MitamaSortParams, Int32> <>9__4_22; //Field offset: 0x58
		public static Func<MitamaSortParams, Int32> <>9__4_23; //Field offset: 0x5C
		public static Func<MitamaSortParams, Int32> <>9__4_24; //Field offset: 0x60
		public static Func<MitamaSortParams, Int32> <>9__4_25; //Field offset: 0x64
		public static Func<MitamaSortParams, Int32> <>9__4_26; //Field offset: 0x68

		private static <>c() { }

		public <>c() { }

		internal int <DoSortAndFilter>b__4_1(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_10(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_11(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_12(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_13(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_14(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_15(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_16(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_17(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_18(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_19(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_2(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_20(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_21(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_22(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_23(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_24(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_25(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_26(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_3(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_4(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_5(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_6(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_7(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_8(MitamaSortParams a) { }

		internal int <DoSortAndFilter>b__4_9(MitamaSortParams a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public List<Int32> have_mitama_list; //Field offset: 0x8
		public List<HeqetCardModel> card_sortfilter_list; //Field offset: 0xC

		public <>c__DisplayClass4_0() { }

		internal MitamaSortParams <DoSortAndFilter>b__0(HeqetCardModel mitama) { }

		internal HeqetCardModel <DoSortAndFilter>b__27(MitamaSortParams obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_1
	{
		public MitamaSortParams obj; //Field offset: 0x8

		public <>c__DisplayClass4_1() { }

		internal bool <DoSortAndFilter>b__28(HeqetCardModel heroine) { }

	}

	internal enum eSortId
	{
		SORT_NO = 0,
		SORT_POWER = 1,
		SORT_LIFE = 2,
		SORT_BOMB = 3,
		SORT_REMAIN = 4,
	}

	internal enum Filter
	{
		NONE = 0,
		ATTRIBUTE_ALL = 1,
		ATTRIBUTE_EM = 2,
		ATTRIBUTE_RO = 3,
		ATTRIBUTE_CO = 4,
		SKILL_T_ALL = 5,
		SKILL_T_BARRAGE = 6,
		SKILL_T_SUPPORT = 7,
		SKILL_T_SCORE = 8,
		SKILL_T_OTHER = 9,
	}

	private struct MitamaSortParams
	{
		public int ID; //Field offset: 0x0
		public int Number; //Field offset: 0x4
		public int Power; //Field offset: 0x8
		public int Life; //Field offset: 0xC
		public int Bomb; //Field offset: 0x10
		public int Remain; //Field offset: 0x14
		public int HaveMitama; //Field offset: 0x18

	}

	internal enum Order
	{
		ASC = 0,
		DESC = 1,
	}


	public GalleryMitamaService() { }

	public static void DoSortAndFilter(List<Int32> mitama_list, List<Int32> have_mitama_list) { }

}

