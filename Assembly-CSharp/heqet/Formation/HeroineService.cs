namespace Heqet.Formation;

public class HeroineService
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Int32> <>9__4_0; //Field offset: 0x4
		public static Comparison<Int32> <>9__4_2; //Field offset: 0x8
		public static Comparison<Int32> <>9__4_3; //Field offset: 0xC
		public static Comparison<Int32> <>9__4_4; //Field offset: 0x10
		public static Comparison<Int32> <>9__4_5; //Field offset: 0x14

		private static <>c() { }

		public <>c() { }

		internal int <DoSortAndFilter>b__4_0(int a, int b) { }

		internal int <DoSortAndFilter>b__4_2(int a, int b) { }

		internal int <DoSortAndFilter>b__4_3(int a, int b) { }

		internal int <DoSortAndFilter>b__4_4(int a, int b) { }

		internal int <DoSortAndFilter>b__4_5(int a, int b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public List<Int32> heroine_list; //Field offset: 0x8

		public <>c__DisplayClass4_0() { }

		internal int <DoSortAndFilter>b__1(int a, int b) { }

	}

	internal enum eSortId
	{
		SORT_NO = 0,
		SORT_OBTAINED = 1,
		SORT_POWER = 2,
		SORT_LIFE = 3,
		SORT_BMOB = 4,
		SORT_MITAMA = 5,
	}

	internal enum Filter
	{
		NONE = 0,
		MAIN_SHOT_ALL = 1,
		MAIN_SHOT_NORMAL = 2,
		MAIN_SHOT_PENETRATION = 3,
		MAIN_SHOT_OTHER = 4,
		EXTRA_SHOT_ALL = 5,
		EXTRA_SHOT_NORMAL = 6,
		EXTRA_SHOT_PENETRATION = 7,
		EXTRA_SHOT_OTHER = 8,
	}

	internal enum Order
	{
		ASC = 0,
		DESC = 1,
	}

	private static Order SortOrder; //Field offset: 0x0

	public HeroineService() { }

	public static void DoSortAndFilter(List<Int32> heroine_list) { }

}

