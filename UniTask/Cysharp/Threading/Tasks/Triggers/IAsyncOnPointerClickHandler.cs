namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnPointerClickHandler
{

	public UniTask<PointerEventData> OnPointerClickAsync() { }

}

