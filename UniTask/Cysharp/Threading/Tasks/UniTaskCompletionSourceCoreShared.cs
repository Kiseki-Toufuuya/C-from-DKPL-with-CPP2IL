namespace Cysharp.Threading.Tasks;

internal static class UniTaskCompletionSourceCoreShared
{
	internal static readonly Action<Object> s_sentinel; //Field offset: 0x0

	private static UniTaskCompletionSourceCoreShared() { }

	private static void CompletionSentinel(object _) { }

}

