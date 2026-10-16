namespace Heqet;

public class SettingResetCategoryComponent : MonoBehaviour
{
	internal enum eResetCategory
	{
		None = 0,
		NoteSpeed = 1,
		Sudden = 2,
		Hidden = 3,
		Mirror = 4,
		Random = 5,
		OuterRandom = 6,
		TapTiming = 7,
		Auto = 8,
		LaneBright = 9,
		TapSe = 10,
		NotesConnection = 11,
		MusicSync = 12,
		BackgroundMovie = 13,
		Skin = 14,
		MusicTiming = 15,
		Max = 16,
	}

	[SerializeField]
	private eResetCategory m_ResetCategory; //Field offset: 0x10

	public eResetCategory ResetCategory
	{
		 get { } //Length: 11
	}

	public SettingResetCategoryComponent() { }

	public eResetCategory get_ResetCategory() { }

}

