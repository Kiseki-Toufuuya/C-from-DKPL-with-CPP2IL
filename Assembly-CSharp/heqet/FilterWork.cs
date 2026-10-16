namespace Heqet;

public class FilterWork
{
	private class FilterData
	{
		public int m_ButtonId; //Field offset: 0x8
		public int m_FilterId; //Field offset: 0xC

		public FilterData() { }

	}

	internal class SetupParam
	{
		public bool isAll; //Field offset: 0x8
		public int buttonId; //Field offset: 0xC
		public int filterId; //Field offset: 0x10

		public SetupParam() { }

	}

	private int m_AllFilterId; //Field offset: 0x8
	private List<FilterData> m_Fliters; //Field offset: 0xC

	public FilterWork() { }

	public void Register(SetupParam _param) { }

	public void UpdateFilter(int _filterId, ref ulong _filter) { }

}

