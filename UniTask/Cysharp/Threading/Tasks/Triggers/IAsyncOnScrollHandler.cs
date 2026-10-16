namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnScrollHandler
{

	public UniTask<PointerEventData> OnScrollAsync() { }

}

