namespace System;

public class ResolveEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly Assembly <RequestingAssembly>k__BackingField; //Field offset: 0xC

	public ResolveEventArgs(string name) { }

	public ResolveEventArgs(string name, Assembly requestingAssembly) { }

}

