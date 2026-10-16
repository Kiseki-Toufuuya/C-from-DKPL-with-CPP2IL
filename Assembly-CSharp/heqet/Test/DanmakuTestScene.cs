namespace Heqet.Test;

public class DanmakuTestScene : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__30_2; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <Start>b__30_2() { }

	}

	public static bool IsDebugSelect; //Field offset: 0x0
	[CompilerGenerated]
	private static string <DebugSceneName>k__BackingField; //Field offset: 0x4
	[SerializeField]
	private InputField m_InputFieldFilter; //Field offset: 0x10
	[SerializeField]
	private Dropdown m_StageDropdown; //Field offset: 0x14
	[SerializeField]
	private Dropdown m_BGDropdown; //Field offset: 0x18
	[SerializeField]
	private Dropdown m_MainCharacterDropdown; //Field offset: 0x1C
	[SerializeField]
	private Dropdown m_SubCharacterDropdown; //Field offset: 0x20
	[SerializeField]
	private Dropdown m_DifficultyDropDown; //Field offset: 0x24
	[SerializeField]
	private Dropdown m_NoteType; //Field offset: 0x28
	[SerializeField]
	private Slider m_SpeedSlider; //Field offset: 0x2C
	[SerializeField]
	private Slider m_SuddenSlider; //Field offset: 0x30
	[SerializeField]
	private Slider m_HiddenSlider; //Field offset: 0x34
	[SerializeField]
	private Text m_NoteSpeedText; //Field offset: 0x38
	[SerializeField]
	private Text m_SuddenText; //Field offset: 0x3C
	[SerializeField]
	private Text m_HiddenText; //Field offset: 0x40
	[SerializeField]
	private Toggle m_AutoPlay; //Field offset: 0x44
	[SerializeField]
	private Button m_ClearBtn; //Field offset: 0x48
	[SerializeField]
	private Button m_ResetBtn; //Field offset: 0x4C
	[SerializeField]
	private Button m_ReturnBtn; //Field offset: 0x50
	[SerializeField]
	private Button m_StartBtn; //Field offset: 0x54
	[SerializeField]
	private GameObject m_Mask; //Field offset: 0x58
	private InGameInfo m_InGameInfo; //Field offset: 0x5C
	private SelectStageInfo m_SelectInfo; //Field offset: 0x60
	private List<WorldStageModel> m_StageList; //Field offset: 0x8C
	private List<StageDropItemInfo> m_StageDropItemList; //Field offset: 0x90
	private readonly Dictionary<String, String> BG_DICTIONARY; //Field offset: 0x94
	private readonly Dictionary<Int32, String> CHARACTER_DICTIONARY; //Field offset: 0x98

	public private static string DebugSceneName
	{
		[CompilerGenerated]
		 get { } //Length: 61
		[CompilerGenerated]
		private set { } //Length: 89
	}

	private static DanmakuTestScene() { }

	public DanmakuTestScene() { }

	[CompilerGenerated]
	private void <Start>b__30_0(bool b) { }

	[CompilerGenerated]
	private void <Start>b__30_1() { }

	private void BGDropdownValueChanged(int index) { }

	[CompilerGenerated]
	public static string get_DebugSceneName() { }

	private void MainCharacterValueChanged(int index) { }

	private void MusicDropdownValueChanged(int index) { }

	private void OnReset() { }

	private void OnStartClick() { }

	private void RefreshStageList(string msg) { }

	private void RefreshUIFromPlayerPrefs() { }

	[CompilerGenerated]
	private static void set_DebugSceneName(string value) { }

	private void SetBGList() { }

	private void SetCharacterList() { }

	private void SetHidden(float value) { }

	private void SetNoteSpeed(float value) { }

	private void SetStageList(string filterString) { }

	private void SetSudden(float value) { }

	private void Start() { }

	private void SubCharacterValueChanged(int index) { }

}

