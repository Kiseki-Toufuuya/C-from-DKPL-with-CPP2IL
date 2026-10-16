namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnDropHandler
{

	public UniTask<PointerEventData> OnDropAsync() { }

}

