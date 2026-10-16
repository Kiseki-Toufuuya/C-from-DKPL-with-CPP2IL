namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnApplicationFocusHandler
{

	public UniTask<Boolean> OnApplicationFocusAsync() { }

}

