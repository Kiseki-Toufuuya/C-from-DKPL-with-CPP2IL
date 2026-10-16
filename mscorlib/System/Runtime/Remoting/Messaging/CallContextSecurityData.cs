namespace System.Runtime.Remoting.Messaging;

internal class CallContextSecurityData : ICloneable
{
	private IPrincipal _principal; //Field offset: 0x8

	internal bool HasInfo
	{
		internal get { } //Length: 15
	}

	public CallContextSecurityData() { }

	public override object Clone() { }

	internal bool get_HasInfo() { }

}

