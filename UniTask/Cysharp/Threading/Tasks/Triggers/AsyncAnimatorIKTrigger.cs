namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncAnimatorIKTrigger : AsyncTriggerBase<Int32>
{

	public AsyncAnimatorIKTrigger() { }

	public IAsyncOnAnimatorIKHandler GetOnAnimatorIKAsyncHandler() { }

	public IAsyncOnAnimatorIKHandler GetOnAnimatorIKAsyncHandler(CancellationToken cancellationToken) { }

	private void OnAnimatorIK(int layerIndex) { }

	public UniTask<Int32> OnAnimatorIKAsync() { }

	public UniTask<Int32> OnAnimatorIKAsync(CancellationToken cancellationToken) { }

}

