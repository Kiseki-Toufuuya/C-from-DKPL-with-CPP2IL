namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnPointerUpHandler
{

	public UniTask<PointerEventData> OnPointerUpAsync() { }

}

