namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncApplicationFocusTrigger : AsyncTriggerBase<Boolean>
{

	public AsyncApplicationFocusTrigger() { }

	public IAsyncOnApplicationFocusHandler GetOnApplicationFocusAsyncHandler() { }

	public IAsyncOnApplicationFocusHandler GetOnApplicationFocusAsyncHandler(CancellationToken cancellationToken) { }

	private void OnApplicationFocus(bool hasFocus) { }

	public UniTask<Boolean> OnApplicationFocusAsync() { }

	public UniTask<Boolean> OnApplicationFocusAsync(CancellationToken cancellationToken) { }

}

