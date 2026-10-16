namespace Cysharp.Threading.Tasks.CompilerServices;

internal interface IStateMachineRunner
{

	public Action MoveNext
	{
		 get { } //Length: 0
	}

	public Action ReturnAction
	{
		 get { } //Length: 0
	}

	public Action get_MoveNext() { }

	public Action get_ReturnAction() { }

}

