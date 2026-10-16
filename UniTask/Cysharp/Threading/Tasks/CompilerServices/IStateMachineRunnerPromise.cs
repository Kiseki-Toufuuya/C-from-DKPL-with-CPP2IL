namespace Cysharp.Threading.Tasks.CompilerServices;

internal interface IStateMachineRunnerPromise : IUniTaskSource
{

	public Action MoveNext
	{
		 get { } //Length: 0
	}

	public UniTask Task
	{
		 get { } //Length: 0
	}

	public Action get_MoveNext() { }

	public UniTask get_Task() { }

	public void SetException(Exception exception) { }

	public void SetResult() { }

}

