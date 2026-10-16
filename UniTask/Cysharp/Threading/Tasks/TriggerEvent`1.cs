namespace Cysharp.Threading.Tasks;

public struct TriggerEvent
{
	private ITriggerHandler<T> head; //Field offset: 0x0
	private ITriggerHandler<T> iteratingHead; //Field offset: 0x0
	private bool preserveRemoveSelf; //Field offset: 0x0
	private ITriggerHandler<T> iteratingNode; //Field offset: 0x0

	public void Add(ITriggerHandler<T> handler) { }

	private void LogError(Exception ex) { }

	public void Remove(ITriggerHandler<T> handler) { }

	public void SetCompleted() { }

	public void SetResult(T value) { }

}

