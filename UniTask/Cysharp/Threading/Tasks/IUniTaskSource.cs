namespace Cysharp.Threading.Tasks;

public interface IUniTaskSource
{

	public void GetResult(short token) { }

	public UniTaskStatus GetStatus(short token) { }

	public void OnCompleted(Action<Object> continuation, object state, short token) { }

	public UniTaskStatus UnsafeGetStatus() { }

}

