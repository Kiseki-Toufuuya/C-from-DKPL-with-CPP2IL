namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnSelectHandler
{

	public UniTask<BaseEventData> OnSelectAsync() { }

}

