namespace Heqet.Formation;

public class MitamaCardService
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Int32> <>9__4_0; //Field offset: 0x4
		public static Comparison<Int32> <>9__4_1; //Field offset: 0x8
		public static Comparison<Int32> <>9__4_2; //Field offset: 0xC
		public static Comparison<Int32> <>9__4_3; //Field offset: 0x10
		public static Comparison<Int32> <>9__4_4; //Field offset: 0x14
		public static Comparison<Int32> <>9__4_5; //Field offset: 0x18
		public static Comparison<Int32> <>9__4_6; //Field offset: 0x1C

		private static <>c() { }

		public <>c() { }

		internal int <DoSortAndFilter>b__4_0(int a, int b) { }

		internal int <DoSortAndFilter>b__4_1(int a, int b) { }

		internal int <DoSortAndFilter>b__4_2(int a, int b) { }

		internal int <DoSortAndFilter>b__4_3(int a, int b) { }

		internal int <DoSortAndFilter>b__4_4(int a, int b) { }

		internal int <DoSortAndFilter>b__4_5(int a, int b) { }

		internal int <DoSortAndFilter>b__4_6(int a, int b) { }

	}

	internal enum eSortId
	{
		SORT_NO = 0,
		SORT_OBTAINED = 1,
		SORT_LEVEL = 2,
		SORT_POWER = 3,
		SORT_LIFE = 4,
		SORT_BMOB = 5,
		SORT_MITAMA = 6,
	}

	internal enum Filter
	{
		NONE = 0,
		ATTRIBUTE_ALL = 1,
		ATTRIBUTE_EM = 2,
		ATTRIBUTE_RO = 3,
		ATTRIBUTE_CO = 4,
		SKILL_TYPE_ALL = 5,
		SKILL_TYPE_BARRAGE = 6,
		SKILL_TYPE_SUPPORT = 7,
		SKILL_TYPE_SCORE = 8,
		SKILL_TYPE_OTHER = 9,
	}

	internal enum Order
	{
		ASC = 0,
		DESC = 1,
	}

	private static Order SortOrder; //Field offset: 0x0

	public MitamaCardService() { }

	public static void DoSortAndFilter(List<Int32> card_list) { }

}

