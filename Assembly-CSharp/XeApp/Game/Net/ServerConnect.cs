namespace XeApp.Game.Net;

public class ServerConnect
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<ServerConnect> <>9__32_0; //Field offset: 0x4
		public static Predicate<ServerConnect> <>9__39_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Init>b__32_0(ServerConnect x) { }

		internal bool <Override>b__39_0(ServerConnect x) { }

	}

	private static bool init; //Field offset: 0x0
	private static ServerConnect m_current; //Field offset: 0x4
	private static ServerConnect m_override; //Field offset: 0x8
	public static List<ServerConnect> Connects; //Field offset: 0xC
	[CompilerGenerated]
	private GuardString <Label>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardString <ServerUri>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardString <AssetUrl>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private GuardString <WebApiHost>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private GuardString <CommonKey>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private GuardInt <GameID>k__BackingField; //Field offset: 0x30
	private bool Default; //Field offset: 0x38

	public private GuardString AssetUrl
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 34
	}

	public private GuardString CommonKey
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 34
	}

	public static ServerConnect Current
	{
		 get { } //Length: 253
		 set { } //Length: 151
	}

	public private GuardInt GameID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public private GuardString Label
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 34
	}

	public static bool OverrideEnable
	{
		 get { } //Length: 53
		 set { } //Length: 55
	}

	public static string OverrideLabel
	{
		 get { } //Length: 62
		 set { } //Length: 65
	}

	public private GuardString ServerUri
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 34
	}

	public private GuardString WebApiHost
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 34
	}

	private static ServerConnect() { }

	public ServerConnect() { }

	[CompilerGenerated]
	public GuardString get_AssetUrl() { }

	[CompilerGenerated]
	public GuardString get_CommonKey() { }

	public static ServerConnect get_Current() { }

	[CompilerGenerated]
	public GuardInt get_GameID() { }

	[CompilerGenerated]
	public GuardString get_Label() { }

	public static bool get_OverrideEnable() { }

	public static string get_OverrideLabel() { }

	[CompilerGenerated]
	public GuardString get_ServerUri() { }

	[CompilerGenerated]
	public GuardString get_WebApiHost() { }

	private static void Init() { }

	private static void Override(string label) { }

	[CompilerGenerated]
	private void set_AssetUrl(GuardString value) { }

	[CompilerGenerated]
	private void set_CommonKey(GuardString value) { }

	public static void set_Current(ServerConnect value) { }

	[CompilerGenerated]
	private void set_GameID(GuardInt value) { }

	[CompilerGenerated]
	private void set_Label(GuardString value) { }

	public static void set_OverrideEnable(bool value) { }

	public static void set_OverrideLabel(string value) { }

	[CompilerGenerated]
	private void set_ServerUri(GuardString value) { }

	[CompilerGenerated]
	private void set_WebApiHost(GuardString value) { }

}

