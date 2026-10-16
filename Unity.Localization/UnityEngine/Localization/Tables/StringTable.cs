namespace UnityEngine.Localization.Tables;

public class StringTable : DetailedLocalizationTable<StringTableEntry>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Char, Char> <>9__0_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal char <GenerateCharacterSet>b__0_0(char c) { }

	}


	public StringTable() { }

	internal IEnumerable<Char> CollectLiteralCharacters() { }

	public virtual StringTableEntry CreateTableEntry() { }

	public string GenerateCharacterSet() { }

}

