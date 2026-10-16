namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncJointBreakTrigger : AsyncTriggerBase<Single>
{

	public AsyncJointBreakTrigger() { }

	public IAsyncOnJointBreakHandler GetOnJointBreakAsyncHandler() { }

	public IAsyncOnJointBreakHandler GetOnJointBreakAsyncHandler(CancellationToken cancellationToken) { }

	private void OnJointBreak(float breakForce) { }

	public UniTask<Single> OnJointBreakAsync() { }

	public UniTask<Single> OnJointBreakAsync(CancellationToken cancellationToken) { }

}

