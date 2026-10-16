namespace UnityEngine.Localization.SmartFormat.Core.Output;

public class StringOutput : IOutput
{
	private readonly StringBuilder output; //Field offset: 0x8

	public StringOutput() { }

	public StringOutput(int capacity) { }

	public StringOutput(StringBuilder output) { }

	public void Clear() { }

	public void SetCapacity(int capacity) { }

	public virtual string ToString() { }

	public override void Write(string text, IFormattingInfo formattingInfo) { }

	public override void Write(string text, int startIndex, int length, IFormattingInfo formattingInfo) { }

}

