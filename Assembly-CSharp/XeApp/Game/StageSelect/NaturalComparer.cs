namespace XeApp.Game.StageSelect;

public class NaturalComparer : IComparer<String>, IComparer
{
	private enum CharTypes
	{
		None = 0,
		Number = 1,
		RomanNumber = 2,
		JpRomanNumber = 4,
		CircleNumber = 8,
		KanjiNumber = 16,
	}

	private class CircleNumberConverter : INumberComverter
	{
		private long _number; //Field offset: 0x8

		public override bool IsError
		{
			 get { } //Length: 3
		}

		public override int Length
		{
			 get { } //Length: 6
		}

		public override long Value
		{
			 get { } //Length: 14
		}

		public CircleNumberConverter(char number) { }

		public override bool AddChar(char number) { }

		public override bool get_IsError() { }

		public override int get_Length() { }

		public override long get_Value() { }

	}

	private interface INumberComverter
	{

		public bool IsError
		{
			 get { } //Length: 0
		}

		public int Length
		{
			 get { } //Length: 0
		}

		public long Value
		{
			 get { } //Length: 0
		}

		public bool AddChar(char number) { }

		public bool get_IsError() { }

		public int get_Length() { }

		public long get_Value() { }

	}

	private class JpRomanNumberConverter : INumberComverter
	{
		private int _length; //Field offset: 0x8
		private bool _isMultiChar; //Field offset: 0xC
		private char _romanOne; //Field offset: 0xE
		private long _number; //Field offset: 0x10
		private long _value; //Field offset: 0x18
		private long _max; //Field offset: 0x20

		public override bool IsError
		{
			 get { } //Length: 3
		}

		public override int Length
		{
			 get { } //Length: 11
		}

		public override long Value
		{
			 get { } //Length: 20
		}

		public JpRomanNumberConverter(char roman) { }

		public override bool AddChar(char roman) { }

		public override bool get_IsError() { }

		public override int get_Length() { }

		public override long get_Value() { }

		protected long Parse(char roman) { }

	}

	private class KanjiNumberConverter : INumberComverter
	{
		private int _length; //Field offset: 0x8
		private bool _isNumeral; //Field offset: 0xC
		private long _number; //Field offset: 0x10
		private long _value1; //Field offset: 0x18
		private long _value2; //Field offset: 0x20
		private long _unit1; //Field offset: 0x28
		private long _unit2; //Field offset: 0x30

		public override bool IsError
		{
			 get { } //Length: 3
		}

		public override int Length
		{
			 get { } //Length: 11
		}

		public override long Value
		{
			 get { } //Length: 26
		}

		public KanjiNumberConverter(char number) { }

		public override bool AddChar(char kanji) { }

		public override bool get_IsError() { }

		public override int get_Length() { }

		public override long get_Value() { }

		protected long Parse(char kanji) { }

	}

	private class NumberConverter : INumberComverter
	{
		private int _length; //Field offset: 0x8
		private char _numberZero; //Field offset: 0xC
		private char _numberNine; //Field offset: 0xE
		private long _value; //Field offset: 0x10
		private bool _isComma; //Field offset: 0x18
		private int _numberCount; //Field offset: 0x1C
		private int _commaLength; //Field offset: 0x20

		public override bool IsError
		{
			 get { } //Length: 3
		}

		public override int Length
		{
			 get { } //Length: 11
		}

		public override long Value
		{
			 get { } //Length: 14
		}

		public NumberConverter(char number) { }

		public override bool AddChar(char number) { }

		public override bool get_IsError() { }

		public override int get_Length() { }

		public override long get_Value() { }

	}

	private class RomanNumberConverter : INumberComverter
	{
		private int _length; //Field offset: 0x8
		private char _alphaA; //Field offset: 0xC
		private long _number; //Field offset: 0x10
		private long _value; //Field offset: 0x18
		private long _max; //Field offset: 0x20
		private bool _isError; //Field offset: 0x28

		public override bool IsError
		{
			 get { } //Length: 11
		}

		public override int Length
		{
			 get { } //Length: 11
		}

		public override long Value
		{
			 get { } //Length: 20
		}

		public RomanNumberConverter(char alpha) { }

		public override bool AddChar(char roman) { }

		public override bool get_IsError() { }

		public override int get_Length() { }

		public override long get_Value() { }

		protected bool IsAlpha(char alpha) { }

		protected long Parse(char alpha) { }

	}

	private int _order; //Field offset: 0x8
	private NaturalComparerOptions _options; //Field offset: 0xC
	private Char[] _ignoreCharacter; //Field offset: 0x10
	private Char[] _ignoreTable; //Field offset: 0x14

	protected override bool IgnoreCase
	{
		 get { } //Length: 16
	}

	protected override bool IgnoreKana
	{
		 get { } //Length: 16
	}

	protected override bool IgnoreNumber
	{
		 get { } //Length: 16
	}

	protected override bool IgnoreSpace
	{
		 get { } //Length: 13
	}

	protected override bool IgnoreWide
	{
		 get { } //Length: 16
	}

	public override NaturalComparerOptions Options
	{
		 get { } //Length: 11
		 set { } //Length: 254
	}

	public override NaturalSortOrder SortOrder
	{
		 get { } //Length: 18
		 set { } //Length: 33
	}

	public NaturalComparer() { }

	public NaturalComparer(NaturalSortOrder order) { }

	public NaturalComparer(NaturalSortOrder order, NaturalComparerOptions options) { }

	public NaturalComparer(NaturalSortOrder order, NaturalComparerOptions options, Char[] ignoreCharacter) { }

	public override int Compare(string s1, string s2) { }

	private int CompareChar(char c1, char c2) { }

	private string ConvertChar(string source) { }

	private void ConvertHalf(StringBuilder source) { }

	private void ConvertKatakana(StringBuilder source) { }

	private void ConvertUpperCase(StringBuilder source) { }

	protected override bool get_IgnoreCase() { }

	protected override bool get_IgnoreKana() { }

	protected override bool get_IgnoreNumber() { }

	protected override bool get_IgnoreSpace() { }

	protected override bool get_IgnoreWide() { }

	public override NaturalComparerOptions get_Options() { }

	public override NaturalSortOrder get_SortOrder() { }

	private CharTypes GetCharType(char c, char back, CharTypes state) { }

	private bool GetNumber(string source, CharTypes type, ref int pos, out long value) { }

	protected override int LocalCompare(string s1, string s2) { }

	public override void set_Options(NaturalComparerOptions value) { }

	public override void set_SortOrder(NaturalSortOrder value) { }

	private void SkipIgnoreCharacter(string source, ref int pos) { }

	private override int System.Collections.IComparer.Compare(object s1, object s2) { }

}

