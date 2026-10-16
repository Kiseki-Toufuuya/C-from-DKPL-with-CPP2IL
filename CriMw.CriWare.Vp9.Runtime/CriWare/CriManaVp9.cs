namespace CriWare;

public static class CriManaVp9
{
	private const string scriptVersionString = "1.01.14"; //Field offset: 0x0
	public const string cri_mana_vp9_name = "cri_mana_vpx"; //Field offset: 0x0

	private static IntPtr criManaUnity_GetAllocatorManager() { }

	private static void criMvPly_AttachCodecInterface(int codec_type, IntPtr codec_if, IntPtr codecalpha_if) { }

	private static IntPtr criVvp9_GetAlphaInterface() { }

	private static IntPtr criVvp9_GetInterface() { }

	private static void criVvp9_SetUserAllocator(IntPtr alloc_func, IntPtr free_func, IntPtr usr_obj) { }

	private static IntPtr criWareUnity_GetAllocateFunc() { }

	private static IntPtr criWareUnity_GetDeallocateFunc() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::AfterAssembliesLoaded (2))]
	private static void RegisterVp9DecoderSetup() { }

	[Preserve]
	public static void SetupVp9Decoder() { }

	[Preserve]
	public static bool SupportCurrentPlatform() { }

}

