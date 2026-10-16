namespace Cysharp.Threading.Tasks;

[AsyncMethodBuilder(typeof(AsyncUniTaskVoidMethodBuilder))]
[IsReadOnly]
public struct UniTaskVoid
{

	public void Forget() { }

}

