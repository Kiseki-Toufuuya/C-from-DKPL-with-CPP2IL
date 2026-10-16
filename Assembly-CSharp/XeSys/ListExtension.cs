namespace XeSys;

[Extension]
public static class ListExtension
{

	[Extension]
	public static bool IsEmpty(List<T> list) { }

	[Extension]
	public static bool IsEmpty(LinkedList<T> list) { }

	[Extension]
	public static void Shuffle(IList<T> list) { }

}

