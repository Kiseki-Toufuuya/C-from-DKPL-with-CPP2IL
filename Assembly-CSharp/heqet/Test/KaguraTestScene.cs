namespace Heqet.Test;

public class KaguraTestScene : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__28_7; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <Start>b__28_7() { }

	}

	public static bool IsDebugSelect; //Field offset: 0x0
	[SerializeField]
	private InputField m_InputFieldFilter; //Field offset: 0x10
	[SerializeField]
	private Dropdown m_MusicDropdown; //Field offset: 0x14
	[SerializeField]
	private Dropdown m_DifficultyDropDown; //Field offset: 0x18
	[SerializeField]
	private Dropdown m_NoteSkinType; //Field offset: 0x1C
	[SerializeField]
	private Dropdown m_NoteTapSEType; //Field offset: 0x20
	[SerializeField]
	private Slider m_SpeedSlider; //Field offset: 0x24
	[SerializeField]
	private Slider m_SuddenSlider; //Field offset: 0x28
	[SerializeField]
	private Slider m_HiddenSlider; //Field offset: 0x2C
	[SerializeField]
	private Text m_NoteSpeedText; //Field offset: 0x30
	[SerializeField]
	private Text m_SuddenText; //Field offset: 0x34
	[SerializeField]
	private Text m_HiddenText; //Field offset: 0x38
	[SerializeField]
	private Toggle m_NoteOuter; //Field offset: 0x3C
	[SerializeField]
	private Toggle m_NoteMirror; //Field offset: 0x40
	[SerializeField]
	private Toggle m_NoteLane; //Field offset: 0x44
	[SerializeField]
	private Toggle m_AutoPlay; //Field offset: 0x48
	[SerializeField]
	private Toggle m_ShowLive2D; //Field offset: 0x4C
	[SerializeField]
	private Toggle m_TouchMode; //Field offset: 0x50
	[SerializeField]
	private Toggle m_ProTapJudge; //Field offset: 0x54
	[SerializeField]
	private Button m_ClearBtn; //Field offset: 0x58
	[SerializeField]
	private Button m_ResetBtn; //Field offset: 0x5C
	[SerializeField]
	private Button m_ReturnBtn; //Field offset: 0x60
	[SerializeField]
	private Button m_StartBtn; //Field offset: 0x64
	[SerializeField]
	private GameObject m_Mask; //Field offset: 0x68
	private InGameInfo m_InGameInfo; //Field offset: 0x6C
	private SelectMusicInfo m_SelectInfo; //Field offset: 0x70
	private List<HeqetMusicModel> m_MusicList; //Field offset: 0xA0
	private List<MusicDropItemInfo> m_MusicDropItemList; //Field offset: 0xA4

	public KaguraTestScene() { }

	[CompilerGenerated]
	private void <Start>b__28_0(int index) { }

	[CompilerGenerated]
	private void <Start>b__28_1(int index) { }

	[CompilerGenerated]
	private void <Start>b__28_2(bool b) { }

	[CompilerGenerated]
	private void <Start>b__28_3(bool b) { }

	[CompilerGenerated]
	private void <Start>b__28_4(bool b) { }

	[CompilerGenerated]
	private void <Start>b__28_5(bool b) { }

	[CompilerGenerated]
	private void <Start>b__28_6() { }

	private void DifficultyValueChanged(int index) { }

	private void MusicDropdownValueChanged(int index) { }

	private void OnReset() { }

	private void OnStartClick() { }

	private void RefreshMusicList(string msg) { }

	private void RefreshUIFromPlayerPrefs() { }

	private void SetHidden(float value) { }

	private void SetMusicList(string filterString) { }

	private void SetNoteRandomLane(bool b) { }

	private void SetNoteRandomMirror(bool b) { }

	private void SetNoteRandomOuter(bool b) { }

	private void SetNoteSpeed(float value) { }

	private void SetNoteTapSEUI() { }

	private void SetSudden(float value) { }

	private void Start() { }

}

