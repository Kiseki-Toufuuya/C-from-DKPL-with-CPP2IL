namespace System.Threading;

public struct AsyncFlowControl : IDisposable
{
	private bool useEC; //Field offset: 0x0
	private ExecutionContext _ec; //Field offset: 0x4
	private Thread _thread; //Field offset: 0x8

	public override void Dispose() { }

	public virtual bool Equals(object obj) { }

	public bool Equals(AsyncFlowControl obj) { }

	public virtual int GetHashCode() { }

	internal void Setup() { }

	public void Undo() { }

}

