namespace Heqet;

public class LocaleFontLoader : MonoBehaviour
{
	[CompilerGenerated]
	private struct <LoadExtFont>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public LocaleFontLoader <>4__this; //Field offset: 0xC
		public string assetName; //Field offset: 0x10
		public TMP_FontAsset baseFontAsset; //Field offset: 0x14
		private AssetBundleLoadAssetOperation <op>5__2; //Field offset: 0x18
		private Awaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public LocaleFontLoader <>4__this; //Field offset: 0x14
		private Awaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static String[] extFontNames; //Field offset: 0x0
	[SerializeField]
	private TMP_FontAsset[] m_FontAssets; //Field offset: 0x10
	private string m_assetPath; //Field offset: 0x14

	private static LocaleFontLoader() { }

	public LocaleFontLoader() { }

	[AsyncStateMachine(typeof(<LoadExtFont>d__4))]
	private UniTask LoadExtFont(TMP_FontAsset baseFontAsset, string assetName) { }

	private void OnDestroy() { }

	[AsyncStateMachine(typeof(<Start>d__3))]
	private void Start() { }

	private void UnloadAssetBundle() { }

}

