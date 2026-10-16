namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnDeselectHandler
{

	public UniTask<BaseEventData> OnDeselectAsync() { }

}

