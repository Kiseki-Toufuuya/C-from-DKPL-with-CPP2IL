namespace Cysharp.Threading.Tasks;

internal static class AwaiterActions
{
	internal static readonly Action<Object> InvokeContinuationDelegate; //Field offset: 0x0

	private static AwaiterActions() { }

	[DebuggerHidden]
	private static void Continuation(object state) { }

}

