namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnPointerDownHandler
{

	public UniTask<PointerEventData> OnPointerDownAsync() { }

}

