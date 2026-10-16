namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnApplicationQuitHandler
{

	public UniTask OnApplicationQuitAsync() { }

}

