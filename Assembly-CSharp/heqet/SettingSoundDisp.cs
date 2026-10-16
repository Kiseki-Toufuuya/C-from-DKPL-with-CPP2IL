namespace Heqet;

public class SettingSoundDisp : SettingDispBase
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
		SystemBgmSubTen = 0,
		SystemBgmSub = 1,
		SystemBgmAdd = 2,
		SystemBgmAddTen = 3,
		SystemSeSubTen = 4,
		SystemSeSub = 5,
		SystemSeAdd = 6,
		SystemSeAddTen = 7,
		MusicBgmSubTen = 8,
		MusicBgmSub = 9,
		MusicBgmAdd = 10,
		MusicBgmAddTen = 11,
		TapSeSubTen = 12,
		TapSeSub = 13,
		TapSeAdd = 14,
		TapSeAddTen = 15,
		DanmakuSeSubTen = 16,
		DanmakuSeSub = 17,
		DanmakuSeAdd = 18,
		DanmakuSeAddTen = 19,
	}

	internal enum eDropdownId
	{
		StageSelectMusic = 0,
	}

	internal enum eImageId
	{
	}

	internal enum eLayerId
	{
		Selectable1 = 0,
		Selectable2 = 1,
		Selectable3 = 2,
		Selectable4 = 3,
		SystemBgmSlider = 4,
		SystemSeSlider = 5,
		MusicBgmSlider = 6,
		TapSeSlider = 7,
		DanmakuSeSlider = 8,
		StageSelectMusicDropdown = 9,
	}

	internal enum eRadioButtonId
	{
	}

	internal enum eSelectedId
	{
		selectable1 = 0,
		selectable2 = 1,
		selectable3 = 2,
		selectable4 = 3,
	}

	internal enum eSliderId
	{
		SystemBgm = 0,
		SystemSe = 1,
		MusicBgm = 2,
		TapSe = 3,
		DanmakuSe = 4,
	}

	internal enum eTabId
	{
	}

	private enum eTextId
	{
		SystemBgmLabel = 0,
		SystemSeLabel = 1,
		MusicBgmLabel = 2,
		TapSeLabel = 3,
		DanmakuSeLabel = 4,
		StageSelectMusicLabel = 5,
		SystemBgmSliderText = 6,
		SystemSeSliderText = 7,
		MusicBgmSliderText = 8,
		TapSeSliderText = 9,
		DanmakuSeSliderText = 10,
		HelpText = 11,
	}

	internal class SetupParam
	{
		public float systemBgm; //Field offset: 0x8
		public float systemSe; //Field offset: 0xC
		public float musicBgm; //Field offset: 0x10
		public float tapSe; //Field offset: 0x14
		public float danmakuSe; //Field offset: 0x18
		public int stageSelectMusic; //Field offset: 0x1C

		public SetupParam() { }

	}

	private static readonly String[] m_LayerList; //Field offset: 0x0
	private static readonly String[] m_TextList; //Field offset: 0x4
	private static readonly String[] m_ImageList; //Field offset: 0x8
	private readonly String[] m_ButtonDataList; //Field offset: 0x170

	private static SettingSoundDisp() { }

	public SettingSoundDisp() { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	protected virtual void OnChangeDropdownValue(int _id, int _value) { }

	protected virtual void OnChangeSliderValue(int _id, float _value, int _decimal) { }

	protected virtual void OnClickButton(int _id) { }

	public virtual void ReleaseAll() { }

	public List<GameObject> SelectedList() { }

	private void SetStageSelectMusicOptions() { }

	public void Setup(SetupParam _param) { }

	private void SetupLabel() { }

	public void UpdateDisp(WorldStageModel stageModel) { }

	protected virtual void UpdateDispMain() { }

}

