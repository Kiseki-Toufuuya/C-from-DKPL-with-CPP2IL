namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnRenderImageHandler
{

	public UniTask<ValueTuple`2<RenderTexture, RenderTexture>> OnRenderImageAsync() { }

}

