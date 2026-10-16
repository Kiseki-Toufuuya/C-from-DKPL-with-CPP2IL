namespace System.Diagnostics;

[ComVisible(True)]
public sealed class Debugger
{
	public static readonly string DefaultCategory; //Field offset: 0x0

	private static Debugger() { }

	public static void NotifyOfCrossThreadDependency() { }

}

