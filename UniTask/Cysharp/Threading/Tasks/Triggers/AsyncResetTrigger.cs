namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncResetTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncResetTrigger() { }

	public IAsyncResetHandler GetResetAsyncHandler() { }

	public IAsyncResetHandler GetResetAsyncHandler(CancellationToken cancellationToken) { }

	private void Reset() { }

	public UniTask ResetAsync() { }

	public UniTask ResetAsync(CancellationToken cancellationToken) { }

}

