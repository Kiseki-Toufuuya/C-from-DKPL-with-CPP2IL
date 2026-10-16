namespace Unity.Services.Analytics.Internal;

internal class IdentityManager : IIdentityManager
{
	private readonly IPlayerId m_PlayerId; //Field offset: 0x8
	private readonly IExternalUserId m_ExternalIdProvider; //Field offset: 0xC
	private readonly IPersistence m_Persistence; //Field offset: 0x10
	private bool m_Initialized; //Field offset: 0x14
	[CompilerGenerated]
	private string <UserId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <InstallId>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private string <ExternalId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsNewPlayer>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private Action OnPlayerChanged; //Field offset: 0x28

	public override event Action OnPlayerChanged
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	public private override string ExternalId
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private override string InstallId
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private override bool IsNewPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public override string PlayerId
	{
		 get { } //Length: 65
	}

	public private override string UserId
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public IdentityManager(IInstallationId installId, IPlayerId playerId, IExternalUserId externalId, IPersistence persistence) { }

	[CompilerGenerated]
	public override void add_OnPlayerChanged(Action value) { }

	private void ExternalUserIdChanged(string newName) { }

	[CompilerGenerated]
	public override string get_ExternalId() { }

	[CompilerGenerated]
	public override string get_InstallId() { }

	[CompilerGenerated]
	public override bool get_IsNewPlayer() { }

	public override string get_PlayerId() { }

	[CompilerGenerated]
	public override string get_UserId() { }

	public override void Initialize() { }

	[CompilerGenerated]
	public override void remove_OnPlayerChanged(Action value) { }

	[CompilerGenerated]
	private void set_ExternalId(string value) { }

	[CompilerGenerated]
	private void set_InstallId(string value) { }

	[CompilerGenerated]
	private void set_IsNewPlayer(bool value) { }

	[CompilerGenerated]
	private void set_UserId(string value) { }

}

