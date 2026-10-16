namespace XeApp;

public sealed class AppEnv
{
	internal enum ActionServerType
	{
		name = 0,
		Count = 1,
	}

	internal enum BuildType
	{
		Production = 0,
		Develop = 1,
		Count = 2,
	}

	internal enum FileServerType
	{
		name = 0,
		Count = 1,
	}

	internal enum LetterBoxDirection
	{
		TopBottom = 0,
		LeftRight = 1,
		Count = 2,
	}

	internal enum PaymentServerType
	{
		name = 0,
		Count = 1,
	}

	internal enum RegionType
	{
		Japan = 0,
		Count = 1,
	}

	internal enum SakashoConnectTargetType
	{
		develop = 0,
		preview = 1,
		server_private = 2,
		release = 3,
		Count = 4,
	}

	public const long BuildTime = 1492080904; //Field offset: 0x0
	public const float BaseWidth = 1334; //Field offset: 0x0
	public const float BaseHeight = 750; //Field offset: 0x0
	public static LetterBoxDirection letterBoxDirection; //Field offset: 0x0
	private static RegionType mRegion; //Field offset: 0x4
	private static BuildType mBuild; //Field offset: 0x8
	private static ActionServerType mActionServerType; //Field offset: 0xC
	public static String[] actionServerUrl; //Field offset: 0x10
	private static FileServerType mFileServerType; //Field offset: 0x14
	public static String[] fileServerUrl; //Field offset: 0x18
	private static PaymentServerType mPaymentServerType; //Field offset: 0x1C
	public static String[] paymentServerUrl; //Field offset: 0x20
	private static SakashoConnectTargetType mSakashoConnectTargetType; //Field offset: 0x24
	public static readonly String[] sakashoConnectTargetType; //Field offset: 0x28

	public static ActionServerType actionServerType
	{
		 get { } //Length: 61
		 set { } //Length: 80
	}

	public static BuildType Build
	{
		 get { } //Length: 61
		 set { } //Length: 80
	}

	public static FileServerType fileServerType
	{
		 get { } //Length: 61
		 set { } //Length: 80
	}

	public static PaymentServerType paymentServerType
	{
		 get { } //Length: 61
		 set { } //Length: 80
	}

	public static RegionType Region
	{
		 get { } //Length: 61
		 set { } //Length: 80
	}

	public static SakashoConnectTargetType SakashoConnectTarget
	{
		 get { } //Length: 61
		 set { } //Length: 80
	}

	private static AppEnv() { }

	public AppEnv() { }

	public static ActionServerType get_actionServerType() { }

	public static BuildType get_Build() { }

	public static FileServerType get_fileServerType() { }

	public static PaymentServerType get_paymentServerType() { }

	public static RegionType get_Region() { }

	public static SakashoConnectTargetType get_SakashoConnectTarget() { }

	public static void set_actionServerType(ActionServerType value) { }

	public static void set_Build(BuildType value) { }

	public static void set_fileServerType(FileServerType value) { }

	public static void set_paymentServerType(PaymentServerType value) { }

	public static void set_Region(RegionType value) { }

	public static void set_SakashoConnectTarget(SakashoConnectTargetType value) { }

}

