namespace System;

public sealed class ConsoleCancelEventArgs : EventArgs
{
	private readonly ConsoleSpecialKey _type; //Field offset: 0x8
	[CompilerGenerated]
	private bool <Cancel>k__BackingField; //Field offset: 0xC

	public bool Cancel
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	internal ConsoleCancelEventArgs(ConsoleSpecialKey type) { }

	internal ConsoleCancelEventArgs() { }

	[CompilerGenerated]
	public bool get_Cancel() { }

}

