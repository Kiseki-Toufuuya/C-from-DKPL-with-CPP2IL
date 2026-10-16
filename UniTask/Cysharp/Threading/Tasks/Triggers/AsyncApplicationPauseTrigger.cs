namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncApplicationPauseTrigger : AsyncTriggerBase<Boolean>
{

	public AsyncApplicationPauseTrigger() { }

	public IAsyncOnApplicationPauseHandler GetOnApplicationPauseAsyncHandler() { }

	public IAsyncOnApplicationPauseHandler GetOnApplicationPauseAsyncHandler(CancellationToken cancellationToken) { }

	private void OnApplicationPause(bool pauseStatus) { }

	public UniTask<Boolean> OnApplicationPauseAsync() { }

	public UniTask<Boolean> OnApplicationPauseAsync(CancellationToken cancellationToken) { }

}

