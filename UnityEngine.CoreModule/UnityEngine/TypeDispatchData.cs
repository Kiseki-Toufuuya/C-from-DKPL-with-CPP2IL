namespace UnityEngine;

internal struct TypeDispatchData : IDisposable
{
	public Object[] changed; //Field offset: 0x0
	public NativeArray<Int32> changedID; //Field offset: 0x4
	public NativeArray<Int32> destroyedID; //Field offset: 0x10

	public override void Dispose() { }

}

