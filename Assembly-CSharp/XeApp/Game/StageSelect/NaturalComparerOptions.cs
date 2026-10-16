namespace XeApp.Game.StageSelect;

[Flags]
public enum NaturalComparerOptions
{
	Number = 1,
	RomanNumber = 2,
	JpRomanNumber = 4,
	CircleNumber = 8,
	KanjiNumber = 16,
	NumberAll = 31,
	IgnoreSpace = 65536,
	IgnoreNumber = 131072,
	IgnoreWide = 262144,
	IgnoreCase = 524288,
	IgnoreKana = 1048576,
	IgnoreAll = 2031616,
	Default = 983071,
}

