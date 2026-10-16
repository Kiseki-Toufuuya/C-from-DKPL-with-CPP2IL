namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncGUITrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncGUITrigger() { }

	public IAsyncOnGUIHandler GetOnGUIAsyncHandler() { }

	public IAsyncOnGUIHandler GetOnGUIAsyncHandler(CancellationToken cancellationToken) { }

	private void OnGUI() { }

	public UniTask OnGUIAsync() { }

	public UniTask OnGUIAsync(CancellationToken cancellationToken) { }

}

