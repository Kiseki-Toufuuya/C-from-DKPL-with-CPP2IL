namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncParticleTriggerTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncParticleTriggerTrigger() { }

	public IAsyncOnParticleTriggerHandler GetOnParticleTriggerAsyncHandler() { }

	public IAsyncOnParticleTriggerHandler GetOnParticleTriggerAsyncHandler(CancellationToken cancellationToken) { }

	private void OnParticleTrigger() { }

	public UniTask OnParticleTriggerAsync() { }

	public UniTask OnParticleTriggerAsync(CancellationToken cancellationToken) { }

}

