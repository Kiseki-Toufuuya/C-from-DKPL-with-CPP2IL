namespace DG.Tweening.Plugins.Options;

public struct StringOptions : IPlugOptions
{
	public bool richTextEnabled; //Field offset: 0x0
	public ScrambleMode scrambleMode; //Field offset: 0x4
	public Char[] scrambledChars; //Field offset: 0x8
	internal int startValueStrippedLength; //Field offset: 0xC
	internal int changeValueStrippedLength; //Field offset: 0x10

	public override void Reset() { }

}

