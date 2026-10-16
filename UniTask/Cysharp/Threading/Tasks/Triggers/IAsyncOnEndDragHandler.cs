namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnEndDragHandler
{

	public UniTask<PointerEventData> OnEndDragAsync() { }

}

