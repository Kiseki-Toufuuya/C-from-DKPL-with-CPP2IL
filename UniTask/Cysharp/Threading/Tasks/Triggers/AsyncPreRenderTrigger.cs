namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncPreRenderTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncPreRenderTrigger() { }

	public IAsyncOnPreRenderHandler GetOnPreRenderAsyncHandler() { }

	public IAsyncOnPreRenderHandler GetOnPreRenderAsyncHandler(CancellationToken cancellationToken) { }

	private void OnPreRender() { }

	public UniTask OnPreRenderAsync() { }

	public UniTask OnPreRenderAsync(CancellationToken cancellationToken) { }

}

