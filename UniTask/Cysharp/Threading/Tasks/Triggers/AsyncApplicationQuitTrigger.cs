namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncApplicationQuitTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncApplicationQuitTrigger() { }

	public IAsyncOnApplicationQuitHandler GetOnApplicationQuitAsyncHandler() { }

	public IAsyncOnApplicationQuitHandler GetOnApplicationQuitAsyncHandler(CancellationToken cancellationToken) { }

	private void OnApplicationQuit() { }

	public UniTask OnApplicationQuitAsync() { }

	public UniTask OnApplicationQuitAsync(CancellationToken cancellationToken) { }

}

