namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnBeginDragHandler
{

	public UniTask<PointerEventData> OnBeginDragAsync() { }

}

