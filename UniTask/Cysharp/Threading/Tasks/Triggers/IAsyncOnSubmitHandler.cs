namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnSubmitHandler
{

	public UniTask<BaseEventData> OnSubmitAsync() { }

}

