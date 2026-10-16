namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnDragHandler
{

	public UniTask<PointerEventData> OnDragAsync() { }

}

