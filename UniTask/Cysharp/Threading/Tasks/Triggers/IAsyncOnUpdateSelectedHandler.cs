namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnUpdateSelectedHandler
{

	public UniTask<BaseEventData> OnUpdateSelectedAsync() { }

}

