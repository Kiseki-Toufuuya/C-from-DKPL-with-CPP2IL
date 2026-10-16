namespace XeSys.Database;

public class ExcelDatabaseListBase : ScriptableObject
{
	[SerializeField]
	protected string m_createDate; //Field offset: 0xC

	public string CreateDate
	{
		 get { } //Length: 11
	}

	public ExcelDatabaseListBase() { }

	public string get_CreateDate() { }

}

