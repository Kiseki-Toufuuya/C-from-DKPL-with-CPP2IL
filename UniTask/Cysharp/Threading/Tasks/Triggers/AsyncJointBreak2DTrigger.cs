namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncJointBreak2DTrigger : AsyncTriggerBase<Joint2D>
{

	public AsyncJointBreak2DTrigger() { }

	public IAsyncOnJointBreak2DHandler GetOnJointBreak2DAsyncHandler() { }

	public IAsyncOnJointBreak2DHandler GetOnJointBreak2DAsyncHandler(CancellationToken cancellationToken) { }

	private void OnJointBreak2D(Joint2D brokenJoint) { }

	public UniTask<Joint2D> OnJointBreak2DAsync() { }

	public UniTask<Joint2D> OnJointBreak2DAsync(CancellationToken cancellationToken) { }

}

