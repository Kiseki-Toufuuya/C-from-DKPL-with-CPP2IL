namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncPostRenderTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncPostRenderTrigger() { }

	public IAsyncOnPostRenderHandler GetOnPostRenderAsyncHandler() { }

	public IAsyncOnPostRenderHandler GetOnPostRenderAsyncHandler(CancellationToken cancellationToken) { }

	private void OnPostRender() { }

	public UniTask OnPostRenderAsync() { }

	public UniTask OnPostRenderAsync(CancellationToken cancellationToken) { }

}

