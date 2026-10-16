namespace Heqet;

public class DLCManager : MonoBehaviour
{
	private static DLCManager instance; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsInitialized>k__BackingField; //Field offset: 0x10
	private Dictionary<Int32, Boolean> dlcInstalledList; //Field offset: 0x14
	[CompilerGenerated]
	private int <MaxNewReleaseDLcId>k__BackingField; //Field offset: 0x18

	public static DLCManager Instance
	{
		 get { } //Length: 40
	}

	public private bool IsInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private int MaxNewReleaseDLcId
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private bool _IsDLCInstalled(DlcListModel model) { }

	public DLCManager() { }

	private void Awake() { }

	public static DLCManager get_Instance() { }

	[CompilerGenerated]
	public bool get_IsInitialized() { }

	[CompilerGenerated]
	public int get_MaxNewReleaseDLcId() { }

	public IList<DlcListModel> GetAllDLCModel() { }

	public static string GetDlcDialogMessage() { }

	private int GetSteamAppID(int id) { }

	public void Initialize() { }

	public bool IsDLCInstalled(int id) { }

	public void OpenAppPage() { }

	public void OpenStorePage(int dlcId) { }

	[CompilerGenerated]
	private void set_IsInitialized(bool value) { }

	[CompilerGenerated]
	private void set_MaxNewReleaseDLcId(int value) { }

}

