namespace XeSys.CSV;

public class CsvReader
{
	internal enum EncodeType
	{
		SJIS = 0,
		EUC = 1,
		UNICODE = 2,
		UTF8 = 3,
		ASCII = 4,
	}

	private static EncodeType mEncodeType; //Field offset: 0x0

	public static EncodeType encodeType
	{
		 get { } //Length: 60
		 set { } //Length: 78
	}

	private static CsvReader() { }

	public CsvReader() { }

	public static ArrayList CsvToArrayList(string csvText) { }

	public static EncodeType get_encodeType() { }

	public static ArrayList LoadCsv(string path) { }

	public static ArrayList LoadCsvFromBytes(Byte[] bytes) { }

	public static void set_encodeType(EncodeType value) { }

}

