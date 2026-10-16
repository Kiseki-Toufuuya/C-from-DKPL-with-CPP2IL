namespace Cysharp.Threading.Tasks;

internal class ExceptionHolder
{
	private ExceptionDispatchInfo exception; //Field offset: 0x8
	private bool calledGet; //Field offset: 0xC

	public ExceptionHolder(ExceptionDispatchInfo exception) { }

	protected virtual void Finalize() { }

	public ExceptionDispatchInfo GetException() { }

}

