namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncAwakeTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncAwakeTrigger() { }

	public UniTask AwakeAsync() { }

}

