namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnApplicationPauseHandler
{

	public UniTask<Boolean> OnApplicationPauseAsync() { }

}

