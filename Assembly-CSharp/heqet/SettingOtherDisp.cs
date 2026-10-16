namespace Heqet;

public class SettingOtherDisp : SettingDispBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, String> <>9__18_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal string <SetupLabel>b__18_0(string _label) { }

	}

	internal enum eButtonId
	{
		TextSpeedSub = 0,
		TextSpeedSubDec = 1,
		TextSpeedAddDec = 2,
		TextSpeedAdd = 3,
		NovelTextSpeedSub = 4,
		NovelTextSpeedSubDec = 5,
		NovelTextSpeedAddDec = 6,
		NovelTextSpeedAdd = 7,
		ViewPageOn = 8,
		ViewPageOff = 9,
		License = 10,
	}

	internal enum eDropdownId
	{
		Resolution = 0,
		DisplayMode = 1,
		FraneRate = 2,
	}

	internal enum eImageId
	{
		ViewPageOn = 0,
		ViewPageOff = 1,
	}

	internal enum eLayerId
	{
		Selectable1 = 0,
		ResolutionDropdown = 1,
		DisplayModeDropdown = 2,
		FrameRateDropdown = 3,
		TextSpeedSlider = 4,
		NovelTextSpeedSlider = 5,
		ViewPageRaidoButton = 6,
	}

	internal enum eRadioButtonId
	{
		ViewPage = 0,
	}

	internal enum eSelectedId
	{
		selectable1 = 0,
	}

	internal enum eSliderId
	{
		TextSpeed = 0,
		NovelTextSpeed = 1,
	}

	internal enum eTabId
	{
	}

	private enum eTextId
	{
		ResolutionLabel = 0,
		DisplayModeLabel = 1,
		FramerateLabel = 2,
		AdventureTextSpeedLabel = 3,
		NovelTextSpeedLabel = 4,
		DisplayPageLabel = 5,
		LicenseLabel = 6,
		TextSpeedText = 7,
		NovelTextSpeedText = 8,
		HelpText = 9,
		LicenseButton = 10,
	}

	internal class SetupParam
	{
		public int diaplayWidth; //Field offset: 0x8
		public int diaplayHeight; //Field offset: 0xC
		public int displayMode; //Field offset: 0x10
		public int displayFramerate; //Field offset: 0x14
		public float adventureTextSpeed; //Field offset: 0x18
		public float novelTextSpeed; //Field offset: 0x1C
		public bool enableDisplayPage; //Field offset: 0x20

		public SetupParam() { }

	}

	private static readonly String[] m_LayerList; //Field offset: 0x0
	private static readonly String[] m_TextList; //Field offset: 0x4
	private static readonly String[] m_ImageList; //Field offset: 0x8
	private readonly String[] m_ButtonDataList; //Field offset: 0x170

	private static SettingOtherDisp() { }

	public SettingOtherDisp() { }

	[CompilerGenerated]
	private void <Setup>b__16_0(int _id, int _value) { }

	public void CallbackInitLayout() { }

	public virtual void CallbackSelect(int button_id, BaseEventData _data) { }

	public virtual void Create(LayerBase parent_layer) { }

	private List<String> GetDisplayModeOptions() { }

	private List<String> GetFrameRateOptions() { }

	private List<String> GetResolutionOptions() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	protected virtual void OnChangeSliderValue(int _id, float _value, int _decimal) { }

	protected virtual void OnClickButton(int _id) { }

	public void RebuildResolutionOptions() { }

	public virtual void ReleaseAll() { }

	public List<GameObject> SelectedList() { }

	public void SetDisplayMode(int _value) { }

	public void Setup(SetupParam _param) { }

	private void SetupLabel() { }

	public void SetValueWithoutNotifyResorution(int _mode, int _resorution) { }

	public void UpdateDisp(WorldStageModel stageModel) { }

	protected virtual void UpdateDispMain() { }

}

