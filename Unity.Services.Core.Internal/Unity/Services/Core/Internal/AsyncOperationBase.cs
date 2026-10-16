namespace Unity.Services.Core.Internal;

internal abstract class AsyncOperationBase : CustomYieldInstruction
{

	public abstract bool IsCompleted
	{
		 get { } //Length: 0
	}

	public virtual bool keepWaiting
	{
		 get { } //Length: 33
	}

	public abstract bool get_IsCompleted() { }

	public virtual bool get_keepWaiting() { }

}

