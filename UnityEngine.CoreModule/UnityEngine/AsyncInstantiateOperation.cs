namespace UnityEngine;

[NativeHeader("Runtime/GameCode/AsyncInstantiate/AsyncInstantiateOperation.h")]
[RequiredByNativeCode]
public class AsyncInstantiateOperation : AsyncOperation
{
	internal static CancellationTokenSource s_GlobalCancellation; //Field offset: 0x0
	internal Object[] m_Result; //Field offset: 0x10
	private CancellationToken m_CancellationToken; //Field offset: 0x14

	private static AsyncInstantiateOperation() { }

	protected AsyncInstantiateOperation(IntPtr ptr, CancellationToken cancellationToken) { }

	internal override Object[] CreateResultArray(int size) { }

	[RequiredByNativeCode(GenerateProxy = True)]
	private bool IsCancellationRequested() { }

}

