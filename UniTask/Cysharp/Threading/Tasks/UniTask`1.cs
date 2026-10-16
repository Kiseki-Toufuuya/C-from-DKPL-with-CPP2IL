namespace Cysharp.Threading.Tasks;

[AsyncMethodBuilder(typeof(AsyncUniTaskMethodBuilder`1))]
[IsReadOnly]
public struct UniTask
{
	private readonly IUniTaskSource<T> source; //Field offset: 0x0
	private readonly T result; //Field offset: 0x0
	private readonly short token; //Field offset: 0x0

	[DebuggerHidden]
	public UniTask`1(IUniTaskSource<T> source, short token) { }

	public virtual string ToString() { }

}

