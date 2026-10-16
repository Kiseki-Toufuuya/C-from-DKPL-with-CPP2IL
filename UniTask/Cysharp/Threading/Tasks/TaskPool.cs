namespace Cysharp.Threading.Tasks;

public static class TaskPool
{
	internal static int MaxPoolSize; //Field offset: 0x0
	private static Dictionary<Type, Func`1<Int32>> sizes; //Field offset: 0x4

	private static TaskPool() { }

	public static void RegisterSizeGetter(Type type, Func<Int32> getSize) { }

}

