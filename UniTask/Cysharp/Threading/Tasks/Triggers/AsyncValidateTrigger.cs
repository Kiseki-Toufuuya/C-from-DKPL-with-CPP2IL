namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncValidateTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncValidateTrigger() { }

	public IAsyncOnValidateHandler GetOnValidateAsyncHandler() { }

	public IAsyncOnValidateHandler GetOnValidateAsyncHandler(CancellationToken cancellationToken) { }

	private void OnValidate() { }

	public UniTask OnValidateAsync() { }

	public UniTask OnValidateAsync(CancellationToken cancellationToken) { }

}

