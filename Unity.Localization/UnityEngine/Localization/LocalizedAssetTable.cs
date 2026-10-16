namespace UnityEngine.Localization;

public class LocalizedAssetTable : LocalizedTable<AssetTable, AssetTableEntry>
{

	protected virtual LocalizedDatabase<AssetTable, AssetTableEntry> Database
	{
		 get { } //Length: 40
	}

	public LocalizedAssetTable() { }

	public LocalizedAssetTable(TableReference tableReference) { }

	protected virtual LocalizedDatabase<AssetTable, AssetTableEntry> get_Database() { }

}

