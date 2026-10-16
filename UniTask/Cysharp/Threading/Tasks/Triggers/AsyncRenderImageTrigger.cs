namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[TupleElementNames(new IL2CPP_TYPE_STRING[] {"source", "destination"})]
public sealed class AsyncRenderImageTrigger : AsyncTriggerBase<ValueTuple`2<RenderTexture, RenderTexture>>
{

	public AsyncRenderImageTrigger() { }

	public IAsyncOnRenderImageHandler GetOnRenderImageAsyncHandler() { }

	public IAsyncOnRenderImageHandler GetOnRenderImageAsyncHandler(CancellationToken cancellationToken) { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public UniTask<ValueTuple`2<RenderTexture, RenderTexture>> OnRenderImageAsync() { }

	public UniTask<ValueTuple`2<RenderTexture, RenderTexture>> OnRenderImageAsync(CancellationToken cancellationToken) { }

}

