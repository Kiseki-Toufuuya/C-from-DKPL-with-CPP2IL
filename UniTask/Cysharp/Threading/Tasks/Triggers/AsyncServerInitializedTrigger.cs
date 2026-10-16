namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncServerInitializedTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncServerInitializedTrigger() { }

	public IAsyncOnServerInitializedHandler GetOnServerInitializedAsyncHandler() { }

	public IAsyncOnServerInitializedHandler GetOnServerInitializedAsyncHandler(CancellationToken cancellationToken) { }

	private void OnServerInitialized() { }

	public UniTask OnServerInitializedAsync() { }

	public UniTask OnServerInitializedAsync(CancellationToken cancellationToken) { }

}

