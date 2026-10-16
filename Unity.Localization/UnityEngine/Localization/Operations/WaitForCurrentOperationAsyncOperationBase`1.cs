namespace UnityEngine.Localization.Operations;

internal abstract class WaitForCurrentOperationAsyncOperationBase : AsyncOperationBase<TObject>
{
	[CompilerGenerated]
	private AsyncOperationHandle <CurrentOperation>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private AsyncOperationHandle <Dependency>k__BackingField; //Field offset: 0x0
	private bool m_Waiting; //Field offset: 0x0

	protected AsyncOperationHandle CurrentOperation
	{
		[CompilerGenerated]
		 get { } //Length: 26
		[CompilerGenerated]
		 set { } //Length: 38
	}

	public AsyncOperationHandle Dependency
	{
		[CompilerGenerated]
		 get { } //Length: 26
		[CompilerGenerated]
		 set { } //Length: 38
	}

	protected WaitForCurrentOperationAsyncOperationBase`1() { }

	protected virtual void Destroy() { }

	[CompilerGenerated]
	protected AsyncOperationHandle get_CurrentOperation() { }

	[CompilerGenerated]
	public AsyncOperationHandle get_Dependency() { }

	protected virtual bool InvokeWaitForCompletion() { }

	[CompilerGenerated]
	protected void set_CurrentOperation(AsyncOperationHandle value) { }

	[CompilerGenerated]
	public void set_Dependency(AsyncOperationHandle value) { }

}

