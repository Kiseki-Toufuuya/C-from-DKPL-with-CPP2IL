namespace Heqet;

public class JacketService
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<JacketSortParams, Int32> <>9__5_1; //Field offset: 0x4
		public static Func<JacketSortParams, Int32> <>9__5_2; //Field offset: 0x8
		public static Func<JacketSortParams, Int32> <>9__5_3; //Field offset: 0xC
		public static Func<JacketSortParams, Int32> <>9__5_4; //Field offset: 0x10
		public static Func<JacketSortParams, Int32> <>9__5_5; //Field offset: 0x14
		public static Func<JacketSortParams, Int32> <>9__5_6; //Field offset: 0x18
		public static Func<JacketSortParams, Int32> <>9__5_7; //Field offset: 0x1C
		public static Func<JacketSortParams, Int32> <>9__5_8; //Field offset: 0x20
		public static Func<JacketSortParams, Int32> <>9__5_9; //Field offset: 0x24
		public static Func<JacketSortParams, String> <>9__5_10; //Field offset: 0x28
		public static Func<JacketSortParams, Int32> <>9__5_11; //Field offset: 0x2C
		public static Func<JacketSortParams, Int32> <>9__5_12; //Field offset: 0x30
		public static Func<JacketSortParams, String> <>9__5_13; //Field offset: 0x34
		public static Func<JacketSortParams, Int32> <>9__5_14; //Field offset: 0x38
		public static Func<JacketSortParams, Int32> <>9__5_15; //Field offset: 0x3C
		public static Func<JacketSortParams, String> <>9__5_16; //Field offset: 0x40
		public static Func<JacketSortParams, Int32> <>9__5_17; //Field offset: 0x44
		public static Func<JacketSortParams, Int32> <>9__5_18; //Field offset: 0x48
		public static Func<JacketSortParams, String> <>9__5_19; //Field offset: 0x4C
		public static Func<JacketSortParams, Int32> <>9__5_20; //Field offset: 0x50

		private static <>c() { }

		public <>c() { }

		internal int <DoSortAndFilter>b__5_1(JacketSortParams a) { }

		internal string <DoSortAndFilter>b__5_10(JacketSortParams a) { }

		internal int <DoSortAndFilter>b__5_11(JacketSortParams a) { }

		internal int <DoSortAndFilter>b__5_12(JacketSortParams a) { }

		internal string <DoSortAndFilter>b__5_13(JacketSortParams a) { }

		internal int <DoSortAndFilter>b__5_14(JacketSortParams a) { }

		internal int <DoSortAndFilter>b__5_15(JacketSortParams a) { }

		internal string <DoSortAndFilter>b__5_16(JacketSortParams a) { }

		internal int <DoSortAndFilter>b__5_17(JacketSortParams a) { }

		internal int <DoSortAndFilter>b__5_18(JacketSortParams a) { }

		internal string <DoSortAndFilter>b__5_19(JacketSortParams a) { }

		internal int <DoSortAndFilter>b__5_2(JacketSortParams a) { }

		internal int <DoSortAndFilter>b__5_20(JacketSortParams a) { }

		internal int <DoSortAndFilter>b__5_3(JacketSortParams a) { }

		internal int <DoSortAndFilter>b__5_4(JacketSortParams a) { }

		internal int <DoSortAndFilter>b__5_5(JacketSortParams a) { }

		internal int <DoSortAndFilter>b__5_6(JacketSortParams a) { }

		internal int <DoSortAndFilter>b__5_7(JacketSortParams a) { }

		internal int <DoSortAndFilter>b__5_8(JacketSortParams a) { }

		internal int <DoSortAndFilter>b__5_9(JacketSortParams a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public List<Int32> have_heroine_list; //Field offset: 0x8
		public List<HeqetMusicModel> music_sortfilter_list; //Field offset: 0xC

		public <>c__DisplayClass5_0() { }

		internal JacketSortParams <DoSortAndFilter>b__0(HeqetMusicModel jacket) { }

		internal HeqetMusicModel <DoSortAndFilter>b__21(JacketSortParams obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_1
	{
		public JacketSortParams obj; //Field offset: 0x8

		public <>c__DisplayClass5_1() { }

		internal bool <DoSortAndFilter>b__22(HeqetMusicModel music) { }

	}

	internal enum eSortId
	{
		SORT_NO = 0,
		SORT_SERIES = 1,
		SORT_NAME = 2,
		SORT_CIRCLE = 3,
	}

	internal enum Filter
	{
		NONE = 0,
		SERIES_ALL = 1,
		SERIES_001 = 2,
		SERIES_002 = 3,
		SERIES_003 = 4,
		SERIES_004 = 5,
		SERIES_005 = 6,
		SERIES_006 = 7,
		SERIES_007 = 8,
		SERIES_008 = 9,
		SERIES_009 = 10,
		SERIES_010 = 11,
		SERIES_011 = 12,
		SERIES_012 = 13,
		SERIES_013 = 14,
		SERIES_014 = 15,
		SERIES_015 = 16,
		SERIES_016 = 17,
		SERIES_017 = 18,
		SERIES_018 = 19,
		SERIES_019 = 20,
		SERIES_020 = 21,
		SERIES_021 = 22,
		SERIES_022 = 23,
		SERIES_023 = 24,
		SERIES_024 = 25,
		SERIES_025 = 26,
		SERIES_026 = 27,
		SERIES_027 = 28,
		SERIES_028 = 29,
		SERIES_029 = 30,
		SERIES_030 = 31,
		SERIES_031 = 32,
		SERIES_032 = 33,
		SERIES_033 = 34,
	}

	private struct JacketSortParams
	{
		public int ID; //Field offset: 0x0
		public int Series; //Field offset: 0x4
		public string Name; //Field offset: 0x8
		public string Circle; //Field offset: 0xC
		public int HaveJacket; //Field offset: 0x10
		public int SortNo; //Field offset: 0x14

	}

	internal enum Order
	{
		ASC = 0,
		DESC = 1,
	}

	private static HeqetMusicSelectionModel m_tmpMusicSelectionModel; //Field offset: 0x0

	public JacketService() { }

	public static void DoSortAndFilter(List<Int32> jacket_list, List<Int32> have_heroine_list) { }

}

