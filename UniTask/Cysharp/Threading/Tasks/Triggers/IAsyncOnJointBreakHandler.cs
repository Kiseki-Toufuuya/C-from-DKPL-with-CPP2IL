namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnJointBreakHandler
{

	public UniTask<Single> OnJointBreakAsync() { }

}

