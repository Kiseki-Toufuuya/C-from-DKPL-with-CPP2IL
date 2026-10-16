namespace Heqet.FilterDialog;

public class FilterDialogInputResult
{
	public string strSearch; //Field offset: 0x8
	public int typeDisp; //Field offset: 0xC
	public eResultType resultType; //Field offset: 0x10

	public FilterDialogInputResult(string str, int type, eResultType result) { }

}

