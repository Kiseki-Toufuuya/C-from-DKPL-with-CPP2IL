namespace UnityEngine.Timeline;

[AssetFileNameExtension("signal", new IL2CPP_TYPE_STRING[] {})]
public class SignalAsset : ScriptableObject
{
	[CompilerGenerated]
	private static Action<SignalAsset> OnEnableCallback; //Field offset: 0x0

	internal static event Action<SignalAsset> OnEnableCallback
	{
		[CompilerGenerated]
		internal add { } //Length: 144
		[CompilerGenerated]
		internal remove { } //Length: 144
	}

	public SignalAsset() { }

	[CompilerGenerated]
	internal static void add_OnEnableCallback(Action<SignalAsset> value) { }

	private void OnEnable() { }

	[CompilerGenerated]
	internal static void remove_OnEnableCallback(Action<SignalAsset> value) { }

}

