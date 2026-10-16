namespace Cysharp.Threading.Tasks.Internal;

internal static class StatePool
{
	private static readonly ConcurrentQueue<StateTuple`1<T1>> queue; //Field offset: 0x0

	private static StatePool`1() { }

	public static StateTuple<T1> Create(T1 item1) { }

	public static void Return(StateTuple<T1> tuple) { }

}

