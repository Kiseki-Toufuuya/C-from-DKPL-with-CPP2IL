namespace Heqet;

public class GalleryEmblemService
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Int32> <>9__4_0; //Field offset: 0x4
		public static Comparison<Int32> <>9__4_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <DoSortAndFilter>b__4_0(int a, int b) { }

		internal int <DoSortAndFilter>b__4_1(int a, int b) { }

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
	}

	internal enum Order
	{
		ASC = 0,
		DESC = 1,
	}

	private static Order SortOrder; //Field offset: 0x0

	public GalleryEmblemService() { }

	public static void DoSortAndFilter(List<Int32> emblem_list) { }

}

