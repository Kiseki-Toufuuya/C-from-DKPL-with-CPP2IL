namespace System.Runtime.CompilerServices;

public class CallSite
{
	internal readonly CallSiteBinder _binder; //Field offset: 0x8
	internal bool _match; //Field offset: 0xC

	public CallSiteBinder Binder
	{
		 get { } //Length: 11
	}

	internal CallSite(CallSiteBinder binder) { }

	public CallSiteBinder get_Binder() { }

}

