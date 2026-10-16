namespace Unity.Services.Core;

public static class UnityServices
{
	[CompilerGenerated]
	private static IUnityServices <Instance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static TaskCompletionSource<Object> <InstantiationCompletion>k__BackingField; //Field offset: 0x4
	internal static ExternalUserIdProperty ExternalUserIdProperty; //Field offset: 0x8
	[CompilerGenerated]
	private static readonly Dictionary<String, IUnityServices> <s_Services>k__BackingField; //Field offset: 0xC

	public static string ExternalUserId
	{
		 get { } //Length: 73
		 set { } //Length: 119
	}

	public static IUnityServices Instance
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		 set { } //Length: 84
	}

	internal static TaskCompletionSource<Object> InstantiationCompletion
	{
		[CompilerGenerated]
		internal get { } //Length: 61
	}

	private static Dictionary<String, IUnityServices> s_Services
	{
		[CompilerGenerated]
		private get { } //Length: 61
	}

	private static UnityServices() { }

	internal static void ClearServices() { }

	public static string get_ExternalUserId() { }

	[CompilerGenerated]
	public static IUnityServices get_Instance() { }

	[CompilerGenerated]
	internal static TaskCompletionSource<Object> get_InstantiationCompletion() { }

	[CompilerGenerated]
	private static Dictionary<String, IUnityServices> get_s_Services() { }

	public static void set_ExternalUserId(string value) { }

	[CompilerGenerated]
	public static void set_Instance(IUnityServices value) { }

}

