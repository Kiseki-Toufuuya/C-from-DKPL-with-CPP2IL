namespace System.Threading;

internal struct CancellationCallbackCoreWorkArguments
{
	internal SparselyPopulatedArrayFragment<CancellationCallbackInfo> _currArrayFragment; //Field offset: 0x0
	internal int _currArrayIndex; //Field offset: 0x4

	public CancellationCallbackCoreWorkArguments(SparselyPopulatedArrayFragment<CancellationCallbackInfo> currArrayFragment, int currArrayIndex) { }

}

