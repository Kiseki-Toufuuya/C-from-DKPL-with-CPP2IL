namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncStartTrigger : AsyncTriggerBase<AsyncUnit>
{
	private bool called; //Field offset: 0x24

	public AsyncStartTrigger() { }

	private void Start() { }

	public UniTask StartAsync() { }

}

