namespace XeSys.uGUI;

public class UIWrapperTab : UIWrapperBase
{
	private class TabButtonData
	{
		private UIWrapperButton m_Button; //Field offset: 0x8
		private TabState m_tabState; //Field offset: 0xC
		private Int32[] m_StateSliceTable; //Field offset: 0x10
		private string m_StaAnimLabel; //Field offset: 0x14
		private string m_EndAnimLabel; //Field offset: 0x18

		public UIWrapperButton Button
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public string EndAnimLabel
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public string StaAnimLabel
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public Int32[] StateSliceTable
		{
			 get { } //Length: 11
		}

		public TabState tabState
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public TabButtonData() { }

		public UIWrapperButton get_Button() { }

		public string get_EndAnimLabel() { }

		public string get_StaAnimLabel() { }

		public Int32[] get_StateSliceTable() { }

		public TabState get_tabState() { }

		public void set_Button(UIWrapperButton value) { }

		public void set_EndAnimLabel(string value) { }

		public void set_StaAnimLabel(string value) { }

		public void set_tabState(TabState value) { }

	}

	internal enum TabState
	{
		Normal = 0,
		Select = 1,
		Lock = 2,
		num = 3,
	}

	private List<TabButtonData> m_TabButtonList; //Field offset: 0x14
	private int m_TabNum; //Field offset: 0x18
	private int m_SelectTab; //Field offset: 0x1C
	private Action<Int32> m_OnSelect; //Field offset: 0x20

	public UIWrapperTab() { }

	public void AddButton(UIWrapperButton button) { }

	public void ClearButtonList() { }

	public UIWrapperButton GetUIButton(int idx) { }

	public int GetUITabNum() { }

	public void OnTabClick(int idx) { }

	public void SelectTab(int idx, bool isAnimation) { }

	public void SetActive(int idx, bool flg) { }

	public void SetAllActive(bool flg) { }

	public void SetOnSelect(Action<Int32> onSelect) { }

	public void SetOnSelect(int idx, TabState state, int sliceNo) { }

	public void SetSelectAnimLabel(int idx, string staLabel, string endLabel) { }

	public void SetTabLock(int idx, bool isLock) { }

	public void SetTabNum(int num, bool isActive) { }

}

