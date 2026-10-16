namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnPointerEnterHandler
{

	public UniTask<PointerEventData> OnPointerEnterAsync() { }

}

