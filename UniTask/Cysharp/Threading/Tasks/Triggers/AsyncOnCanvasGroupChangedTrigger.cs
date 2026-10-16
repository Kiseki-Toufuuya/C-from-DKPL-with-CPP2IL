namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncOnCanvasGroupChangedTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncOnCanvasGroupChangedTrigger() { }

	public IAsyncOnCanvasGroupChangedHandler GetOnCanvasGroupChangedAsyncHandler() { }

	public IAsyncOnCanvasGroupChangedHandler GetOnCanvasGroupChangedAsyncHandler(CancellationToken cancellationToken) { }

	private void OnCanvasGroupChanged() { }

	public UniTask OnCanvasGroupChangedAsync() { }

	public UniTask OnCanvasGroupChangedAsync(CancellationToken cancellationToken) { }

}

