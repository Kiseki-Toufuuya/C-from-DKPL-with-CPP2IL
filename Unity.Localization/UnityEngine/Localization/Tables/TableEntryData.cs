namespace UnityEngine.Localization.Tables;

internal class TableEntryData
{
	[SerializeField]
	private long m_Id; //Field offset: 0x8
	[SerializeField]
	private string m_Localized; //Field offset: 0x10
	[SerializeField]
	private MetadataCollection m_Metadata; //Field offset: 0x14

	public long Id
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	public string Localized
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public MetadataCollection Metadata
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public TableEntryData() { }

	public TableEntryData(long id) { }

	public TableEntryData(long id, string localized) { }

	public long get_Id() { }

	public string get_Localized() { }

	public MetadataCollection get_Metadata() { }

	public void set_Id(long value) { }

	public void set_Localized(string value) { }

	public void set_Metadata(MetadataCollection value) { }

}

