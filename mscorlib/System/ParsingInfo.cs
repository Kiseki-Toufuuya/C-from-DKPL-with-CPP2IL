namespace System;

internal struct ParsingInfo
{
	internal Calendar calendar; //Field offset: 0x0
	internal int dayOfWeek; //Field offset: 0x4
	internal TM timeMark; //Field offset: 0x8
	internal bool fUseHour12; //Field offset: 0xC
	internal bool fUseTwoDigitYear; //Field offset: 0xD
	internal bool fAllowInnerWhite; //Field offset: 0xE
	internal bool fAllowTrailingWhite; //Field offset: 0xF
	internal bool fCustomNumberParser; //Field offset: 0x10
	internal MatchNumberDelegate parseNumberDelegate; //Field offset: 0x14

	internal void Init() { }

}

