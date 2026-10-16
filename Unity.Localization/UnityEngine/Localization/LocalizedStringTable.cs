namespace UnityEngine.Localization;

public class LocalizedStringTable : LocalizedTable<StringTable, StringTableEntry>
{

	protected virtual LocalizedDatabase<StringTable, StringTableEntry> Database
	{
		 get { } //Length: 40
	}

	public LocalizedStringTable() { }

	public LocalizedStringTable(TableReference tableReference) { }

	protected virtual LocalizedDatabase<StringTable, StringTableEntry> get_Database() { }

}

