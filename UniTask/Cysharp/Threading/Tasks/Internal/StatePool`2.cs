namespace Cysharp.Threading.Tasks.Internal;

internal static class StatePool
{
	private static readonly ConcurrentQueue<StateTuple`2<T1, T2>> queue; //Field offset: 0x0

	private static StatePool`2() { }

	public static StateTuple<T1, T2> Create(T1 item1, T2 item2) { }

	public static void Return(StateTuple<T1, T2> tuple) { }

}

