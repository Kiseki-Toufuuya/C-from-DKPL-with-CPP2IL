namespace Heqet;

public class GalleryHeroineService
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<HeroineSortParams, Int32> <>9__4_1; //Field offset: 0x4
		public static Func<HeroineSortParams, Int32> <>9__4_2; //Field offset: 0x8
		public static Func<HeroineSortParams, Int32> <>9__4_3; //Field offset: 0xC
		public static Func<HeroineSortParams, Int32> <>9__4_4; //Field offset: 0x10
		public static Func<HeroineSortParams, Int32> <>9__4_5; //Field offset: 0x14
		public static Func<HeroineSortParams, Int32> <>9__4_6; //Field offset: 0x18
		public static Func<HeroineSortParams, Int32> <>9__4_7; //Field offset: 0x1C
		public static Func<HeroineSortParams, Int32> <>9__4_8; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal int <DoSortAndFilter>b__4_1(HeroineSortParams a) { }

		internal int <DoSortAndFilter>b__4_2(HeroineSortParams a) { }

		internal int <DoSortAndFilter>b__4_3(HeroineSortParams a) { }

		internal int <DoSortAndFilter>b__4_4(HeroineSortParams a) { }

		internal int <DoSortAndFilter>b__4_5(HeroineSortParams a) { }

		internal int <DoSortAndFilter>b__4_6(HeroineSortParams a) { }

		internal int <DoSortAndFilter>b__4_7(HeroineSortParams a) { }

		internal int <DoSortAndFilter>b__4_8(HeroineSortParams a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public List<Int32> have_heroine_list; //Field offset: 0x8
		public List<HeqetHeroineModel> heroine_sortfilter_list; //Field offset: 0xC

		public <>c__DisplayClass4_0() { }

		internal HeroineSortParams <DoSortAndFilter>b__0(HeqetHeroineModel heroine) { }

		internal HeqetHeroineModel <DoSortAndFilter>b__9(HeroineSortParams obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_1
	{
		public HeroineSortParams obj; //Field offset: 0x8

		public <>c__DisplayClass4_1() { }

		internal bool <DoSortAndFilter>b__10(HeqetHeroineModel heroine) { }

	}

	internal enum eSortId
	{
		SORT_NO = 0,
		SORT_SERIES = 1,
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

	private struct HeroineSortParams
	{
		public int ID; //Field offset: 0x0
		public int Number; //Field offset: 0x4
		public int FirstSeriesNum; //Field offset: 0x8
		public int SeriesBossId; //Field offset: 0xC
		public int HaveHeroine; //Field offset: 0x10

	}

	internal enum Order
	{
		ASC = 0,
		DESC = 1,
	}


	public GalleryHeroineService() { }

	public static void DoSortAndFilter(List<Int32> heroine_list, List<Int32> have_heroine_list) { }

}

