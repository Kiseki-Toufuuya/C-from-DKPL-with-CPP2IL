namespace System.Threading.Tasks;

public class UnobservedTaskExceptionEventArgs : EventArgs
{
	private AggregateException m_exception; //Field offset: 0x8
	internal bool m_observed; //Field offset: 0xC

	public UnobservedTaskExceptionEventArgs(AggregateException exception) { }

}

