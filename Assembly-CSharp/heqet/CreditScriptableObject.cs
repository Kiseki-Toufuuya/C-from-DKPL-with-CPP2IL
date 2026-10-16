namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/CreditRepository")]
[MovedFrom(False, null, null, "CreditRepository")]
public class CreditScriptableObject : ScriptableObject, IJsonImportExport
{
	internal class Data
	{
		public string Value; //Field offset: 0x8
		public float Position; //Field offset: 0xC
		public float Size; //Field offset: 0x10
		public int Line; //Field offset: 0x14
		public int RowIndex; //Field offset: 0x18

		public Data() { }

	}

	internal enum StaffCreditType
	{
		LageCategory = 0,
		JobPositon = 1,
		PersonName = 2,
	}

	[SerializeField]
	private TextAsset OutputFontBaseTextFile; //Field offset: 0xC
	[SerializeField]
	private List<Data> entityList; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public CreditScriptableObject() { }

	public override void FromJson(string json) { }

	public List<Data> get_Entries() { }

	public override string ToJson() { }

}

