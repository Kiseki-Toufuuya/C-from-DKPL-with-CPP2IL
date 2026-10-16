namespace System.Runtime.Serialization;

internal static class SerializationTrace
{
	private static TraceSource codeGen; //Field offset: 0x0

	internal static SourceSwitch CodeGenerationSwitch
	{
		internal get { } //Length: 152
	}

	private static TraceSource CodeGenerationTraceSource
	{
		private get { } //Length: 131
	}

	internal static SourceSwitch get_CodeGenerationSwitch() { }

	private static TraceSource get_CodeGenerationTraceSource() { }

	internal static void TraceInstruction(string instruction) { }

	internal static void WriteInstruction(int lineNumber, string instruction) { }

}

