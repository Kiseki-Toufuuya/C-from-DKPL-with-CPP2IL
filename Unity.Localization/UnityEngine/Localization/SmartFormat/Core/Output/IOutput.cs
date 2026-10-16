namespace UnityEngine.Localization.SmartFormat.Core.Output;

public interface IOutput
{

	public void Write(string text, IFormattingInfo formattingInfo) { }

	public void Write(string text, int startIndex, int length, IFormattingInfo formattingInfo) { }

}

