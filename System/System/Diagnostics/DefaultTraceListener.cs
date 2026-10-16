namespace System.Diagnostics;

public class DefaultTraceListener : TraceListener
{
	private static readonly bool OnWin32; //Field offset: 0x0
	private static readonly string MonoTracePrefix; //Field offset: 0x4
	private static readonly string MonoTraceFile; //Field offset: 0x8

	private static DefaultTraceListener() { }

	public DefaultTraceListener() { }

	private static string GetPrefix(string var, string target) { }

}

