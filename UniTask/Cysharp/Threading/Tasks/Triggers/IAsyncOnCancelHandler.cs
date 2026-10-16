namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnCancelHandler
{

	public UniTask<BaseEventData> OnCancelAsync() { }

}

