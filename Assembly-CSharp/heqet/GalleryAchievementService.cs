namespace Heqet;

public class GalleryAchievementService
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Int32> <>9__4_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <DoSortAndFilter>b__4_0(int a, int b) { }

	}

	internal enum eSortId
	{
		SORT_NO = 0,
	}

	internal enum Filter
	{
		NONE = 0,
		ACHIEVE_ALL = 0,
		ACHIEVE_TRUE = 1,
		ACHIEVE_FALSE = 2,
		SKILL_ALL = 3,
		SKILL_BARRAGE = 4,
		SKILL_SUPPORT = 5,
		SKILL_SCORE = 6,
		SKILL_OTHER = 7,
	}

	internal enum Order
	{
		ASC = 0,
		DESC = 1,
	}

	private static Order SortOrder; //Field offset: 0x0

	public GalleryAchievementService() { }

	public static void DoSortAndFilter(List<Int32> achievement_list) { }

}

