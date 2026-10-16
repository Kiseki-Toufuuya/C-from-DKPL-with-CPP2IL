namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnPointerExitHandler
{

	public UniTask<PointerEventData> OnPointerExitAsync() { }

}

