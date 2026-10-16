namespace Unity.Services.Core.Device;

internal class InstallationId : IInstallationId, IServiceComponent
{
	internal string Identifier; //Field offset: 0x8
	internal IUserIdentifierProvider UnityAdsIdentifierProvider; //Field offset: 0xC
	internal IUserIdentifierProvider UnityAnalyticsIdentifierProvider; //Field offset: 0x10
	internal IUserIdentifierProvider UnityEngineIdentifierProvider; //Field offset: 0x14

	public InstallationId() { }

	public void CreateIdentifier() { }

	private static string GenerateGuid() { }

	public override string GetOrCreateIdentifier() { }

	private static string ReadIdentifierFromFile() { }

	private static void WriteIdentifierToFile(string identifier) { }

}

