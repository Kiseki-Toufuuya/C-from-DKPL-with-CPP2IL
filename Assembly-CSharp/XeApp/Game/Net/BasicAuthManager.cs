namespace XeApp.Game.Net;

public class BasicAuthManager
{
	private static BasicAuth basicAuth; //Field offset: 0x0
	private static CipherRijndael cipher; //Field offset: 0x4
	public static string User; //Field offset: 0x8
	public static string Pass; //Field offset: 0xC

	private static BasicAuthManager() { }

	public BasicAuthManager() { }

	public static void Apply(UnityWebRequest requester) { }

	public static void ApplyToCriFsWebInstaller() { }

	private static void Init() { }

	public static bool IsUseBasicAuth() { }

	public static string Load(string key) { }

	public static void Save(string key, string value) { }

}

