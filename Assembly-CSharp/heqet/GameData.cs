namespace Heqet;

public class GameData : Singleton<GameData>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SaveReturnCode, Boolean> <>9__21_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <Load>b__21_0(SaveReturnCode result) { }

	}

	private LocalSaveData<SystemData> systemData; //Field offset: 0x8
	private LocalSaveData<PlayerData> playerData; //Field offset: 0xC
	[CompilerGenerated]
	private TemporaryData <TemporaryData>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private SaveReturnCode <LastReturnCode>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private bool <IsLastActionSave>k__BackingField; //Field offset: 0x18

	public private bool IsLastActionSave
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private SaveReturnCode LastReturnCode
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public PlayerData PlayerData
	{
		 get { } //Length: 23
	}

	public bool PlayrDataExists
	{
		 get { } //Length: 64
	}

	public SystemData SystemData
	{
		 get { } //Length: 23
	}

	public private TemporaryData TemporaryData
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public GameData() { }

	private void CommitFileData() { }

	public bool DeleteSaveFile() { }

	[CompilerGenerated]
	public bool get_IsLastActionSave() { }

	[CompilerGenerated]
	public SaveReturnCode get_LastReturnCode() { }

	public PlayerData get_PlayerData() { }

	public bool get_PlayrDataExists() { }

	public SystemData get_SystemData() { }

	[CompilerGenerated]
	public TemporaryData get_TemporaryData() { }

	public bool Load() { }

	public void Reset() { }

	public bool Save() { }

	[CompilerGenerated]
	private void set_IsLastActionSave(bool value) { }

	[CompilerGenerated]
	private void set_LastReturnCode(SaveReturnCode value) { }

	[CompilerGenerated]
	private void set_TemporaryData(TemporaryData value) { }

}

